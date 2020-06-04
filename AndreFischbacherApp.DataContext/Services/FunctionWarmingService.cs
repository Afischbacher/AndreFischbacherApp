using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AndreFischbacherApp.DataContext.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;

namespace AndreFischbacherApp.DataContext.Services
{
	public interface IFunctionWarmingService
	{
		Task<bool> WarmUpFunctions<T>(Type type) where T : Attribute;
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

		public async Task<bool> WarmUpFunctions<T>(Type type) where T : Attribute
		{
			try
			{
				// Dynamically retrieve routes from Azure Functions
				var functionMethodParameters = type.GetMethods().Select(c => c.GetParameters());

				var functionParameterTypes = functionMethodParameters
					.SelectMany(p => p.SelectMany(c => c.CustomAttributes))
					.Where(x => x.AttributeType == typeof(T) && x.NamedArguments.Any());

				var functionRoutes = functionParameterTypes.SelectMany(p => p.NamedArguments.Select(c => c.TypedValue.Value.ToString()));

				// No routes found, exit
				if (!functionRoutes.Any()) return true;

				var functionWarmingRequests = functionRoutes.Select(route =>
				{
					return Task.Run(async () =>
					{
						await _httpClient.GetAsync($"{_appConfiguration.BaseApiUrl}{route}");
					});

				});

				// Execute Http requests in parallel
				await Task.WhenAll(functionWarmingRequests);

				return true;
			}
			catch
			{
				throw;
			}
		}
	}
}
