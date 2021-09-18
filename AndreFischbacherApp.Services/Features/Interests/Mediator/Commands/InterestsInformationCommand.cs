using AndreFischbacherApp.DataContext.Entities;
using AndreFischbacherApp.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Services.Features.Interests.Mediator.Commands
{
	/// <summary>
	/// A command that returns information about interests
	/// </summary>
	public class InterestsInformationCommand : IRequest<List<InterestContent>>
	{
		public class InterestsInformationCommandHandler : IRequestHandler<InterestsInformationCommand, List<InterestContent>>
		{
			private readonly IInterestsContentRepository _interestsContentRepository;

			public InterestsInformationCommandHandler
			(
				IInterestsContentRepository interestsContentRepository
			)
			{
				_interestsContentRepository = interestsContentRepository;
			}
			public async Task<List<InterestContent>> Handle(InterestsInformationCommand request, CancellationToken cancellationToken)
			{
				return await _interestsContentRepository.GetInterestContentsAsync();
			}
		}
	}
}
