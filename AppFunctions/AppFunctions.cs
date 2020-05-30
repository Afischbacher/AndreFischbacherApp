using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using System.Net.Http;
using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.DataContext.Repositories;

namespace AndreFischbacherApp.Functions
{
	public class AppFunctions
	{
		private readonly IInterestsContentRepository _interestsContentRepository;
		private readonly IAboutMeContentRepository _aboutMeContentRepository;
		private readonly ICareerContentRepository _careerContentRepository;
		private readonly IAppConfiguration _appConfiguration;
		private readonly HttpClient _httpClient;

		public AppFunctions
			(
				IInterestsContentRepository interestsContentRepository,
				IAboutMeContentRepository aboutMeContentRepository,
				ICareerContentRepository careerContentRepository,
				IAppConfiguration appConfiguration,
				HttpClient httpClient
			)
		{
			_interestsContentRepository = interestsContentRepository;
			_aboutMeContentRepository = aboutMeContentRepository;
			_careerContentRepository = careerContentRepository;
			_appConfiguration = appConfiguration;
			_httpClient = httpClient;
		}

		[FunctionName("AboutFunction")]
		public async Task<IActionResult> AboutFunction(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "about")] HttpRequest req,
			ILogger log)
		{
		
			var aboutMeContents = await _aboutMeContentRepository.GetAboutContentsAsync();
			return new OkObjectResult(aboutMeContents);
		}

		[FunctionName("InterestsFunction")]
		public async Task<IActionResult> InterestsFunction(
		  [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "interests")] HttpRequest req,
		  ILogger log)
		{
			var interestsContents = await _interestsContentRepository.GetInterestContentsAsync();
			return new OkObjectResult(interestsContents);
		}

		[FunctionName("CareerFunction")]
		public async Task<IActionResult> CareerFunction(
		  [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "career")] HttpRequest req,
		  ILogger log)
		{
			var careerInformationContents = (await _careerContentRepository
				.GetCareerContentsWithCareerInformationAsync())
				.OrderByDescending(c => c.EndDate ?? DateTimeOffset.MaxValue);

			return new OkObjectResult(careerInformationContents);
		}

		[FunctionName("WarmUpFunction")]
		public async Task<IActionResult> WarmUpFunction(
		  [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "warmup")] HttpRequest req,
		  ILogger log)
		{
			return await Task.Run(() => new OkObjectResult(true));
		}

		[FunctionName("PerformanceFunction")]
		public async Task Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
		{
			await _httpClient.GetAsync($"{_appConfiguration.BaseApiUrl}/warmup");
		}
	}
}
