using AndreFischbacherApp.DataContext.Configuration;
using AndreFischbacherApp.Repositories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using AndreFischbacherApp.Services.Mediator.Base;
using AndreFischbacherApp.Services.Features.Functions.Services;
using AndreFischbacherApp.Common.Mediator.Base;

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
			configuration.AddUserSecrets<Startup>(optional: true, reloadOnChange: true);

			var configurationRoot = configuration.Build();

			var connectionString = configurationRoot["AndreFischbacherApp:Database:ConnectionString"] ?? configurationRoot["DatabaseConnectionString"];
			// Add DbContext and SQL connection
			builder.Services.AddDbContextPool<IAndreFischbacherAppContext, AndreFischbacherAppContext>(options => options.UseSqlServer(connectionString));

			// Register Mediator
			builder.Services.AddMediatR(new[] { typeof(IMediatorServicesBase), typeof(IMediatorBase) });

			// Http Client
			builder.Services.AddHttpClient();

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
