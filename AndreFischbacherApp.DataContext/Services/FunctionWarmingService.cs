using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.DataContext.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace AndreFischbacherApp.DataContext.Services
{
	public interface IFunctionWarmingService
	{
		Task<bool> WarmUpFunctions<T>(Type type, IEnumerable<AuthorizationLevel> authorizationLevels) where T : Attribute;
	}

	public class FunctionWarmingService : IFunctionWarmingService
	{
		private readonly HttpClient _httpClient;
		private readonly IAppConfiguration _appConfiguration;

		public FunctionWarmingService(HttpClient httpClient, IAppConfiguration appConfiguration)
		{
			_httpClient = httpClient;
			_appConfiguration = appConfiguration;
		}

		public async Task<bool> WarmUpFunctions<T>(Type type, IEnumerable<AuthorizationLevel> authorizationLevels) where T : Attribute
		{
			const string routeMemberName = "Route";
			try
			{
			
				var authorizationLevelsAsInt = authorizationLevels.Select(a => (int)a);

				// Dynamically retrieve routes from Azure Functions
				var functionMethodParameters = type.GetMethods().Select(c => c.GetParameters());

				var functionParameterTypes = functionMethodParameters
					.SelectMany(p => p.SelectMany(c => c.CustomAttributes))
					.Where(p => p.AttributeType == typeof(T) && p.NamedArguments.Any() && p.ConstructorArguments.Any());

				var functionRoutes = functionParameterTypes
					.Where(f => f.ConstructorArguments.Any(c => authorizationLevelsAsInt.Contains((int)c.Value)))
					.SelectMany(p => p.NamedArguments
					.Where(m => m.MemberName == routeMemberName).Select(v =>  v.TypedValue.Value.ToString()));

				// No routes found, exit
				if (!functionRoutes.Any()) return true;

				var functionWarmingRequests = functionRoutes.Select(route =>
				{
					return Task.Run(async () =>
					{
						await _httpClient.GetAsync($"{_appConfiguration.BaseApiUrl}/{route}");
					});

				});

				// Execute Http requests in parallel
				await Task.WhenAll(functionWarmingRequests);

				return true;
			}
			catch
			{
				throw new FunctionWarmUpExecutionException();
			}
		}
	}
}
