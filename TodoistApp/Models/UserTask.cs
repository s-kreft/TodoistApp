namespace TodoistApp.Models
{
    public class UserTask
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public DateTimeOffset TaskComplitionDay { get; set; }
    }
}
