using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using AndreFischbacherApp.DataContext.Repositories;

namespace AndreFischbacherApp.Functions
{
	public class AppFunctions
	{
		private readonly IInterestsContentRepository _interestsContentRepository;
		private readonly IAboutMeContentRepository _aboutMeContentRepository;
		private readonly ICareerContentRepository _careerContentRepository;

		public AppFunctions
			(
				IInterestsContentRepository interestsContentRepository,
				IAboutMeContentRepository aboutMeContentRepository,
				ICareerContentRepository careerContentRepository
			)
		{
			_interestsContentRepository = interestsContentRepository;
			_aboutMeContentRepository = aboutMeContentRepository;
			_careerContentRepository = careerContentRepository;
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
	}
}
