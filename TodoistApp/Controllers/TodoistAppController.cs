using Microsoft.AspNetCore.Mvc;
using TodoistApp.Models;
using TodoistApp.Services;

namespace TodoistApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoistAppController : ControllerBase
    {
        private readonly ITodoistAppService _todoistAppService;

        public TodoistAppController(ITodoistAppService todoistAppService)
        {
            _todoistAppService = todoistAppService;
        }

        [HttpPut]
        [Route("/put")]
        public async Task<ActionResult<List<UserTask>>> putUserTask([FromBody]UserTask userTask)
        {
            return await _todoistAppService.GetTaskFromUser(userTask);
        }
    }
}
