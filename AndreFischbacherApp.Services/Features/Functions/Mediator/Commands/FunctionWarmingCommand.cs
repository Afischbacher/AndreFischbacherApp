using AndreFischbacherApp.Services.Features.Functions.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Services.Features.Functions.Mediator.Commands
{
	/// <summary>
	/// Warm's up the API endpoint's to prevent them from going to sleep
	/// </summary>
	public class FunctionWarmingCommand : IRequest<bool>
	{
		public class FunctionWarmingCommandHandler : IRequestHandler<FunctionWarmingCommand, bool>
		{
			private readonly IFunctionWarmingService _functionWarmingService;

			public FunctionWarmingCommandHandler(IFunctionWarmingService functionWarmingService)
			{
				_functionWarmingService = functionWarmingService;
			}
			public async Task<bool> Handle(FunctionWarmingCommand request, CancellationToken cancellationToken)
			{
				return await _functionWarmingService.WarmUpFunctions();
			}
		}
	}
}
