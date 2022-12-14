using HttpClienteFactory_PollyRetry_Project.Configuration;
using HttpClientFactory_PollyRetry_Project.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HttpClientFactory_PollyRetry_Project.Services
{
    public class TodoService : ITodoService
    {
        private readonly IApiConfig _config;
        private readonly HttpClient _httpClient;

        public TodoService(
            IApiConfig config,
            HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<TodoModel> GetTodo(int id)
        {
            return await _httpClient.GetFromJsonAsync<TodoModel>(
              $"{_config.BaseUrl}todos/{id}"
              );
        }
    }
}
