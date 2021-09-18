using AndreFischbacherApp.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Repositories
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
