using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MediatR;
using AndreFischbacherApp.DataContext.Mediator.Commands;

namespace AndreFischbacherApp.Functions.v1.Http
{
	public class InterestsHttpTriggerFunction
	{
		private readonly IMediator _mediator;

		public InterestsHttpTriggerFunction(IMediator mediator)
		{
			_mediator = mediator;
		}

		[FunctionName("InterestsFunction")]
		public async Task<IActionResult> InterestsFunction([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "interests")] HttpRequest httpRequest, ILogger log)
		{
			var interestsContents = await _mediator.Send(new InterestsInformationCommand());
			return new OkObjectResult(interestsContents);
		}
	}
}
