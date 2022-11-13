namespace HttpClienteFactory_PollyRetry_Project.Configuration
{
    public interface IApiConfig
    {
        public string BaseUrl { get; set; }
    }
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; }
    }
}
