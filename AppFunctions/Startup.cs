using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.DataContext.Repositories;
using AndreFischbacherApp.DataContext.Services;
using AndreFischbacherApp.Repositories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using MediatR;
using AndreFischbacherApp.DataContext.Mediator.Base;

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

			var connectionString = configurationRoot["AndreFischbacherApp:Database:ConnectionString"] ?? configurationRoot["DatabaseConnectionString"];

			// Add DbContext and SQL connection
			builder.Services.AddDbContext<IAndreFischbacherAppContext, AndreFischbacherAppContext>
				(options => options.UseSqlServer(connectionString));

			// Register Mediator
			builder.Services.AddMediatR(typeof(IMediatorDataContextBase));

			// Http Client
			builder.Services.AddSingleton(new HttpClient());

			// App Settings
			builder.Services.AddScoped<IAppConfiguration, AppConfiguration>();

			// Repositories
			builder.Services.AddScoped<IInterestsContentRepository, InterestsContentRepository>();
			builder.Services.AddScoped<IAboutMeContentRepository, AboutMeContentRepository>();
			builder.Services.AddScoped<ICareerContentRepository, CareerContentRepository>();

			// Services
			builder.Services.AddScoped<IFunctionWarmingService, FunctionWarmingService>();

		}
	}
}
