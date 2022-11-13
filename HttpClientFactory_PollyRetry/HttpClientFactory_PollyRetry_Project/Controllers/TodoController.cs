using HttpClientFactory_PollyRetry_Project.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HttpClientFactory_PollyRetry_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        //Injetar o servico de TODO
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        //Metodos de Obtencao de TODOS
        [HttpGet("GetTodo/{id}")]
        public async Task<ActionResult> GetTodo(int id)
        {          
            return Ok(await _todoService.GetTodo(id));
        }
    }
}
