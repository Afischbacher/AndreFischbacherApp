using AndreFischbacherApp.Repositories;
using AndreFischbacherApp.Repositories.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Services.Features.About.Mediator.Commands
{
	/// <summary>
	/// A command that returns about information content 
	/// </summary>
	public class AboutInformationCommand : IRequest<List<AboutContent>>
	{
		public class AboutInformationCommandHandler : IRequestHandler<AboutInformationCommand, List<AboutContent>>
		{
			private readonly IAboutMeContentRepository _aboutMeContentRepository;

			public AboutInformationCommandHandler
			(
				IAboutMeContentRepository aboutMeContentRepository	
			)
			{
				_aboutMeContentRepository = aboutMeContentRepository;
			}
			public async Task<List<AboutContent>> Handle(AboutInformationCommand request, CancellationToken cancellationToken)
			{
				return await _aboutMeContentRepository.GetAboutContentsAsync();
			}
		}
	}
}
