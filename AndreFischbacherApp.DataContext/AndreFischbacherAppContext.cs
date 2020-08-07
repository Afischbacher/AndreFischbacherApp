using AndreFischbacherApp.DataContext.Entities;
using AndreFischbacherApp.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;

namespace AndreFischbacherApp.Repositories
{
	public interface IAndreFischbacherAppContext
	{

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

		public DbSet<AboutContent> AboutContents { get; set; }
		public DbSet<CareerContent> CareerContents { get; set; }
		public DbSet<InterestContent> InterestContents { get; set; }
		public DbSet<CareerInformationContent> CareerInformationContents { get; set; }

	}


	public class AndreFischbacherAppContextFactory : IDesignTimeDbContextFactory<AndreFischbacherAppContext>
	{
		public AndreFischbacherAppContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder();

			var configurationRoot = configuration
				.AddUserSecrets(Assembly.GetExecutingAssembly(), optional: false, reloadOnChange: true)
				.Build();

			var connectionString = configurationRoot["AndreFischbacherApp:Database:ConnectionString"] ?? configurationRoot["DatabaseConnectionString"];;

			var builder = new DbContextOptionsBuilder<AndreFischbacherAppContext>();

			builder.UseSqlServer(connectionString);

			return new AndreFischbacherAppContext(builder.Options);

		}
	}
}
