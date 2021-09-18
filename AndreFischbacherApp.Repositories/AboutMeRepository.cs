using AndreFischbacherApp.Repositories;
using AndreFischbacherApp.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Repositories
{
	public interface IAboutMeContentRepository
	{
		Task<List<AboutContent>> GetAboutContentsAsync();
	}
	public class AboutMeContentRepository : IAboutMeContentRepository
	{
		private readonly IAndreFischbacherAppContext _andreFischbacherAppContext;

		public AboutMeContentRepository(IAndreFischbacherAppContext andreFischbacherAppContext)
		{
			_andreFischbacherAppContext = andreFischbacherAppContext;
		}

		public async Task<List<AboutContent>> GetAboutContentsAsync()
		{
			return await _andreFischbacherAppContext.AboutContents.ToListAsync();
		}
	}
}
