using TodoistApp.Models;

namespace TodoistApp.Services
{
    public class TodoistAppService : ITodoistAppService
    {
        List<UserTask> UserTasksList = new List<UserTask>();
        public TodoistAppService()
        {

        }

        public async Task<List<UserTask>> SaveTaskFromUser(UserTask userTask)
        {
            UserTasksList.Add(userTask);

            return UserTasksList;
        }
    }
}
