using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.DataContext.Exceptions;

namespace AndreFischbacherApp.Services.Features.Functions.Services
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
				foreach (var baseApiUrl in _appConfiguration.BaseApiUrls)
				{
					var functionRoutes = _appConfiguration.ApiRoutes.Select(endpoint =>
					{
						return $"{baseApiUrl}{endpoint}";
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
				}

				return true;
			}
			catch (Exception exception)
			{
				throw new FunctionWarmUpExecutionException("Failed to warm up Azure Functions", exception);
			}
		}
	}
}
