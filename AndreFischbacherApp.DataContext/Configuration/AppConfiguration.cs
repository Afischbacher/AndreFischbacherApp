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
		
		public HashSet<string> ApiRoutes => new HashSet<string> { "/about", "/interests", "/career" };

		public HashSet<string> BaseApiUrls => new HashSet<string>
			{
				"https://andre-fischbacher-app-canada-central.azurewebsites.net",
				"https://andre-fischbacher-app-east-us.azurewebsites.net",
				"https://andre-fischbacher-app-west-us.azurewebsites.net"
			};
	}
}
