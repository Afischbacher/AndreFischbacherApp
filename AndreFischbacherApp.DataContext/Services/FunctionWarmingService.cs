using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.DataContext.Exceptions;

namespace AndreFischbacherApp.DataContext.Services
{
	public interface IFunctionWarmingService
	{
		Task<bool> WarmUpFunctions();
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

		public async Task<bool> WarmUpFunctions() 
		{
			try
			{

				var functionRoutes = _appConfiguration.ApiEndpoints.Select(endpoint =>
				{
					return $"{_appConfiguration.BaseApiUrl}{endpoint}";
				});

				var functionWarmingRequests = functionRoutes.Select(route =>
				{
					return Task.Run(async () =>
					{
						await _httpClient.GetAsync(route);
					});

				});

				// Execute Http requests in parallel
				await Task.WhenAll(functionWarmingRequests);

				return true;
			}
			catch (Exception exception)
			{
				throw new FunctionWarmUpExecutionException("Failed to warm up Azure Functions", exception);
			}
		}
	}
}
