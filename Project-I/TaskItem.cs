using System;

namespace Project_I
{
    public class TaskItem  
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Project { get; set; }
        public bool Status { get; set; }

        public TaskItem(string title, DateTime dueDate, string project)
        {
            Title = title;
            DueDate = dueDate;
            Project = project;
            Status = false;
        }

        public void EditTask(string title, DateTime dueDate, string project, bool status)
        {
            Title = title;
            DueDate = dueDate;
            Project = project;
            Status = status;
        }
    }
}
