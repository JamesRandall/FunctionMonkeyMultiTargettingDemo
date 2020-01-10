using AzureFromTheTrenches.Commanding.Abstractions;
using ToDo.Application.Model;

namespace ToDo.Application.Commands
{
    public class CreateToDoItemCommand : ICommand<ToDoItem>
    {
        public string Title { get; set; }
    }
}