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
	public class AboutMeHttpTriggerFunction
	{
		private readonly IMediator _mediator;

		public AboutMeHttpTriggerFunction(IMediator mediator)
		{
			_mediator = mediator;
		}


		[FunctionName("AboutHttpTriggerFunction")]
		public async Task<IActionResult> AboutFunction([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "about")] HttpRequest httpRequest, ILogger log)
		{
			var aboutInformation = await _mediator.Send(new AboutInformationCommand());
			return new OkObjectResult(aboutInformation);
		}

	}
}
