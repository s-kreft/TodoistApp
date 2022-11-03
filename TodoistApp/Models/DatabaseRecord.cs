namespace TodoistApp.Models
{
    public class DatabaseRecord
    {
        public int Id { get; set; }
        private string _taskDescription { get; set; }
        private DateOnly _taskComplitionDay { get; set; }

        public DatabaseRecord(UserInput userInput)
        {
            _taskDescription = userInput._taskDescription;
            _taskComplitionDay = userInput._taskComplitionDay;
        }


    }
}
