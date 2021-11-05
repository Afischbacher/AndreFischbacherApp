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
		
		public HashSet<string> ApiRoutes => new HashSet<string> { "/about" };

		public HashSet<string> BaseApiUrls => new HashSet<string>
		{
			"https://api.andrefischbacher.com/v1"
		};
	}
}
