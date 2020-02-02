using AndreFischbacherApp.DataContext.Entities;
using AndreFischbacherApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndreFischbacherApp.DataContext.Repositories
{
	public interface ICareerContentRepository
	{
		Task<List<CareerContent>> GetCareerContentsWithCareerInformationAsync();
	}

	public class CareerContentRepository : ICareerContentRepository
	{
		private readonly IAndreFischbacherAppContext _andreFischbacherAppContext;

		public CareerContentRepository(IAndreFischbacherAppContext andreFischbacherAppContext)
		{
			_andreFischbacherAppContext = andreFischbacherAppContext;
		}

		public async Task<List<CareerContent>> GetCareerContentsWithCareerInformationAsync()
		{
			return await _andreFischbacherAppContext.CareerContents.Include(careerInformationContent => careerInformationContent.CareerInformationContents).ToListAsync();
		}
	}
}
