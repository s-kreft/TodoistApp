namespace TodoistApp.Models
{
    public class UserInput
    {
        public string _taskDescription { get; set; }
        public DateOnly _taskComplitionDay { get; set; }

        public UserInput(string taskDescription, DateOnly taskComplitionDay)
        {
            _taskDescription = taskDescription;
            _taskComplitionDay = taskComplitionDay;
        }
    }
}
