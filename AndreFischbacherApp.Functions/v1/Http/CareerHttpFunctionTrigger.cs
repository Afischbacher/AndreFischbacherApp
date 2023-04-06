using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MediatR;
using AndreFischbacherApp.Services.Features.Career.Mediator.Commands;

namespace AndreFischbacherApp.Functions.v1.Http
{
	public class CareerHttpFunctionTrigger
	{
		private readonly IMediator _mediator;

		public CareerHttpFunctionTrigger(IMediator mediator)
		{
			_mediator = mediator;
		}

		[FunctionName(nameof(CareerHttpFunctionTrigger))]
		public async Task<IActionResult> CareerFunction([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "career")] HttpRequest httpRequest, ILogger log)
		{
			var careerInformationContents = await _mediator.Send(new CareerInformationCommand());
			return new OkObjectResult(careerInformationContents);
		}
	}
}
