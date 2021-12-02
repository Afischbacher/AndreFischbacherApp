using System.Threading.Tasks;
using AndreFischbacherApp.Services.Features.Functions.Mediator.Commands;
using MediatR;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AndreFischbacherApp.Functions.v1.Timer
{
	public class FunctionWarmingTimerTriggerFunction
	{
		private readonly IMediator _mediator;

		[FunctionName("FunctionWarmingTimerTriggerFunction")]
		public async Task Run([TimerTrigger("0 */2 * * * *", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
		{
		}
	}
}
