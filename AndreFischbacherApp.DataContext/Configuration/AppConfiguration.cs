using System.Collections.Generic;

namespace AndreFischbacherApp.DataContext.Configuration
{
	public interface IAppConfiguration
	{
		public HashSet<string> ApiRoutes { get; }

		public HashSet<string> BaseApiUrls { get; }
	}

	public class AppConfiguration : IAppConfiguration
	{
		
		public HashSet<string> ApiRoutes => new HashSet<string> { "/ok" };

		public HashSet<string> BaseApiUrls => new HashSet<string>
		{
			"https://api.andrefischbacher.com/v1",
			"https://andre-fischbacher-app-east-us.azurewebsites.net/v1",
			"https://andre-fischbacher-app-west-us.azurewebsites.net/v1",
			"https://andre-fischbacher-app-canada-central.azurewebsites.net/v1"
		};
	}
}
