namespace AndreFischbacherApp.DataContext.Configuration
{
	public interface IAppConfiguration
	{
		string BaseApiUrl { get; }
	}

	public class AppConfiguration : IAppConfiguration
	{
		public string BaseApiUrl => "https://andrefischbacherappfunctions.azurewebsites.net/v1";
	}
}
