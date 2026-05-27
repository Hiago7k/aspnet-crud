using MeuTodo.Data;
using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Controllers
{
    [ApiController] 
    [Route(template:"v1")] 
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route(template:"todos")]
        public async Task<IActionResult> Get(
            [FromServices]AppDbContext context)
        {
            var todos = await context.Todos.AsNoTracking().ToListAsync();
            return Ok(todos);
        }
    } 
}
