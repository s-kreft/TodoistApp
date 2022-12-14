using TodoistApp.Models;

namespace TodoistApp.Services
{
    public interface ITodoistAppService
    {
        Task<List<UserTask>> SaveTaskFromUser(UserInput userInput);
    }
}