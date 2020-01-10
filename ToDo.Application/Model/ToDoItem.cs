using System;

namespace ToDo.Application.Model
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public bool IsComplete { get; set; }
    }
}