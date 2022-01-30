using AndreFischbacherApp.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _memoryCache;

        public CareerContentRepository(IAndreFischbacherAppContext andreFischbacherAppContext, IMemoryCache memoryCache)
        {
            _andreFischbacherAppContext = andreFischbacherAppContext;
            _memoryCache = memoryCache;
        }

        public async Task<List<CareerContent>> GetCareerContentsWithCareerInformationAsync()
        {
            List<CareerContent> careerContents;

            var cachedContent = _memoryCache.Get<List<CareerContent>>(nameof(careerContents));
            if (cachedContent != null)
            {
                return cachedContent;
            }

            careerContents = await _andreFischbacherAppContext.CareerContents
                .Include(careerInformationContent => careerInformationContent.CareerInformationContents)
                .ToListAsync();

            _memoryCache.Set(nameof(careerContents), careerContents, new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = System.DateTimeOffset.Now.AddDays(1),
            });

            return careerContents;
        }
    }
}
