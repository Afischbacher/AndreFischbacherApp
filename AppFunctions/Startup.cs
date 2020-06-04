using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.DataContext.Repositories;
using AndreFischbacherApp.DataContext.Services;
using AndreFischbacherApp.Repositories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

[assembly: FunctionsStartup(typeof(AndreFischbacherApp.Functions.Startup))]
namespace AndreFischbacherApp.Functions
{
	public class Startup : FunctionsStartup
	{
		private static string GetKeyVaultEndpoint => "https://andrefischbacherkeyvault.vault.azure.net/";

		public override void Configure(IFunctionsHostBuilder builder)
		{
			var configuration = new ConfigurationBuilder();

			configuration.AddAzureKeyVault(GetKeyVaultEndpoint);

			configuration.AddUserSecrets<Startup>();

			var configurationRoot = configuration.Build();

			var _connectionString = configurationRoot["AndreFischbacherApp:Database:ConnectionString"] ?? configurationRoot["DatabaseConnectionString"];

			builder.Services.AddSingleton(new HttpClient());
			builder.Services.AddTransient<IAppConfiguration, AppConfiguration>();
			builder.Services.AddDbContext<IAndreFischbacherAppContext, AndreFischbacherAppContext>
				(options => options.UseSqlServer(_connectionString));

			builder.Services.AddTransient<IInterestsContentRepository, InterestsContentRepository>();
			builder.Services.AddTransient<IAboutMeContentRepository, AboutMeContentRepository>();
			builder.Services.AddTransient<ICareerContentRepository, CareerContentRepository>();

			builder.Services.AddTransient<IFunctionWarmingService, FunctionWarmingService>();



		}
	}
}
