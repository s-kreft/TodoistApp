﻿namespace TodoistApp.Models
{
    public class UserTask
    {
        private string _taskDescription { get; set; }
        private DateOnly _taskComplitionDay { get; set; }

        public UserTask(UserInput userInput)
        {
            _taskDescription = userInput._taskDescription;
        }
    }
}
