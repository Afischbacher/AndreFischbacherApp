using System.Collections.Generic;
using System.Threading.Tasks;
using AndreFischbacherApp.Services.Features.Functions.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace AndreFischbacherApp.Functions.v1.Timer
{
	public class FunctionWarmingTimerTriggerFunction
	{
		private readonly IMediator _mediator;

		public FunctionWarmingTimerTriggerFunction
		(
			IMediator mediator
		)
		{
			_mediator = mediator;
		}

		[FunctionName("FunctionWarmingTimerTriggerFunction")]
		public async Task Run([TimerTrigger("0 */15 * * * *", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
		{
			await _mediator.Send(new FunctionWarmingCommand());

		}
	}
}
