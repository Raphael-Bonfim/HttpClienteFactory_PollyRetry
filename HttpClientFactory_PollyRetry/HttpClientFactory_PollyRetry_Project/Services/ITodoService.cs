using HttpClientFactory_PollyRetry_Project.Models;
using System.Threading.Tasks;

namespace HttpClientFactory_PollyRetry_Project.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(int id);
    }
}
