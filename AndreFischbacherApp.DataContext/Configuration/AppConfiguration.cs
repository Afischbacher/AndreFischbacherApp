namespace AndreFischbacherApp.DataContext.Configuration
{
	public interface IAppConfiguration
	{
		string BaseApiUrl { get; }
	}

	public class AppConfiguration : IAppConfiguration
	{
		public string BaseApiUrl => "https://api.andrefischbacher.com/v1";
	}
}
