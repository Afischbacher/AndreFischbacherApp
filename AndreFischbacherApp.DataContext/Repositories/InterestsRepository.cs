using AndreFischbacherApp.DataContext.Entities;
using AndreFischbacherApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndreFischbacherApp.DataContext.Repositories
{
    public interface IInterestsContentRepository
    {
        Task<List<InterestContent>> GetInterestContentsAsync();
    }

    public class InterestsContentRepository : IInterestsContentRepository
    {
        private readonly IAndreFischbacherAppContext _andreFischbacherAppContext;

        public InterestsContentRepository(IAndreFischbacherAppContext andreFischbacherAppContext)
        {
            _andreFischbacherAppContext = andreFischbacherAppContext;
        }

        public async Task<List<InterestContent>> GetInterestContentsAsync()
        {
            return await _andreFischbacherAppContext.InterestContents.ToListAsync();
        } 
    }
}
