namespace AndreFischbacherApp.DataContext.Configuration
{
	public interface IAppConfiguration
	{
		string BaseApiUrl { get; }

		string[] ApiEndpoints { get; }
	}

	public class AppConfiguration : IAppConfiguration
	{
		public string BaseApiUrl => "https://api.andrefischbacher.com/v1";

		public string[] ApiEndpoints => new [] { "/about", "/interests", "/career" };
	}
}
