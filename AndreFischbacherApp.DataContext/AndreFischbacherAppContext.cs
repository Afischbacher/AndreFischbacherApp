using AndreFischbacherApp.DataContext.Entities;
using AndreFischbacherApp.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Threading.Tasks;

namespace AndreFischbacherApp.Repositories
{
    public interface IAndreFischbacherAppContext
	{
		Task<int> SaveChangesAsync();
		DbSet<AboutContent> AboutContents { get; set; }
		DbSet<CareerContent> CareerContents { get; set; }
		DbSet<InterestContent> InterestContents { get; set; }
		DbSet<CareerInformationContent> CareerInformationContents { get; set; }
	}

	public class AndreFischbacherAppContext : DbContext, IAndreFischbacherAppContext
	{

		public AndreFischbacherAppContext(DbContextOptions<AndreFischbacherAppContext> dbContextOptions) : base(dbContextOptions)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}

		public async Task<int> SaveChangesAsync()
		{
			return await base.SaveChangesAsync();
		}

		public virtual DbSet<AboutContent> AboutContents { get; set; }
		public virtual DbSet<CareerContent> CareerContents { get; set; }
		public virtual DbSet<InterestContent> InterestContents { get; set; }
		public virtual DbSet<CareerInformationContent> CareerInformationContents { get; set; }

	}


	public class AndreFischbacherAppContextFactory : IDesignTimeDbContextFactory<AndreFischbacherAppContext>
	{
        private readonly IConfiguration _configuration;
        private readonly IMemoryCache _memoryCache;

        public AndreFischbacherAppContextFactory(IConfiguration configuration, IMemoryCache memoryCache)
        {
            _configuration = configuration;
            _memoryCache = memoryCache;
        }

		public AndreFischbacherAppContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder();
			
			_configuration.GetConnectionString("DatabaseConnectionString");

			var configurationRoot = configuration
				.AddUserSecrets(Assembly.GetExecutingAssembly(), optional: false, reloadOnChange: true)
				.Build();

			var connectionString = _configuration.GetConnectionString("DatabaseConnectionString")
				?? configurationRoot["AndreFischbacherApp:Database:ConnectionString"] 
				?? configurationRoot["DatabaseConnectionString"];;

			var builder = new DbContextOptionsBuilder<AndreFischbacherAppContext>();

			builder.UseSqlServer(connectionString);
			builder.UseMemoryCache(_memoryCache);

			return new AndreFischbacherAppContext(builder.Options);

		}
	}
}
