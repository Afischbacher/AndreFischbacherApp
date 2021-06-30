using AndreFischbacherApp.DataContext.Services;
using MediatR;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AndreFischbacherApp.DataContext.Mediator.Commands
{
	public class FunctionWarmingCommand : IRequest<bool>
	{
		public Type Type { get; set; }

		public List<AuthorizationLevel> AuthorizationLevels { get; set; }

		public class FunctionWarmingCommandHandler : IRequestHandler<FunctionWarmingCommand, bool>
		{
			private readonly IFunctionWarmingService _functionWarmingService;

			public FunctionWarmingCommandHandler(IFunctionWarmingService functionWarmingService)
			{
				_functionWarmingService = functionWarmingService;
			}
			public async Task<bool> Handle(FunctionWarmingCommand request, CancellationToken cancellationToken)
			{
				var type = request.Type;
				var authorizationLevels = request.AuthorizationLevels;
				return await _functionWarmingService.WarmUpFunctions<HttpTriggerAttribute>(type, authorizationLevels);
			}
		}
	}
}
