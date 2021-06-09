using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using AndreFischbacherApp.DataContext.Repositories;
using AndreFischbacherApp.DataContext.Services;

namespace AndreFischbacherApp.Functions
{

	public class AppFunctions
	{
		private readonly IInterestsContentRepository _interestsContentRepository;
		private readonly IAboutMeContentRepository _aboutMeContentRepository;
		private readonly ICareerContentRepository _careerContentRepository;
		private readonly IFunctionWarmingService _functionWarmingService;

		public AppFunctions
			(
				IInterestsContentRepository interestsContentRepository,
				IAboutMeContentRepository aboutMeContentRepository,
				ICareerContentRepository careerContentRepository,
				IFunctionWarmingService functionWarmingService
			)
		{
			_interestsContentRepository = interestsContentRepository;
			_aboutMeContentRepository = aboutMeContentRepository;
			_careerContentRepository = careerContentRepository;
			_functionWarmingService = functionWarmingService;
		}

		[FunctionName("AboutFunction")]
		public async Task<IActionResult> AboutFunction(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "about")] HttpRequest httpRequest,
			ILogger log)
		{
		
			var aboutMeContents = await _aboutMeContentRepository.GetAboutContentsAsync();
			return new OkObjectResult(aboutMeContents);
		}

		[FunctionName("InterestsFunction")]
		public async Task<IActionResult> InterestsFunction(
		  [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "interests")] HttpRequest httpRequest,
		  ILogger log)
		{
			var interestsContents = await _interestsContentRepository.GetInterestContentsAsync();
			return new OkObjectResult(interestsContents);
		}

		[FunctionName("CareerFunction")]
		public async Task<IActionResult> CareerFunction(
		  [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "career")] HttpRequest httpRequest,
		  ILogger log)
		{
			var careerInformationContents = (await _careerContentRepository
				.GetCareerContentsWithCareerInformationAsync())
				.OrderByDescending(c => c.EndDate ?? DateTimeOffset.MaxValue);

			return new OkObjectResult(careerInformationContents);
		}

		[FunctionName("PerformanceFunction")]
		public async Task PerformanceFunction([TimerTrigger("0 */20 * * * *", RunOnStartup = true)]TimerInfo myTimer, ILogger log)
		{
			log.LogInformation("PerformanceFunction started");

			await _functionWarmingService.WarmUpFunctions<HttpTriggerAttribute>(GetType(), new[] { AuthorizationLevel.Anonymous });

			log.LogInformation("PerformanceFunction finished");
		}
	}
}
