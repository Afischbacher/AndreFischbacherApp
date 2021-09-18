using AndreFischbacherApp.DataContext.Entities;
using AndreFischbacherApp.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Services.Features.Career.Mediator.Commands
{
	/// <summary>
	/// A command to return all of the career information and contents
	/// </summary>
	public class CareerInformationCommand : IRequest<List<CareerContent>>
	{
		public class CareerInformationCommandHandler : IRequestHandler<CareerInformationCommand, List<CareerContent>>
		{
			private readonly ICareerContentRepository _careerContentRepository;

			public CareerInformationCommandHandler
			(
				ICareerContentRepository careerContentRepository	
			)
			{
				_careerContentRepository = careerContentRepository;
			}

			public async Task<List<CareerContent>> Handle(CareerInformationCommand request, CancellationToken cancellationToken)
			{
				return (await _careerContentRepository
				.GetCareerContentsWithCareerInformationAsync())
				.OrderByDescending(c => c.EndDate ?? DateTimeOffset.MaxValue)
				.ToList();
			}
		}
	}
}
