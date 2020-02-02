namespace AndreFischbacherApp.DataContext.Configuration
{
    public interface IAppConfiguration
    {
        string BaseApiUrl { get;  }
    }

    public class AppConfiguration : IAppConfiguration
    {
        public string BaseApiUrl => "http://api.andrefischbacher.com/v1";
    }
}
