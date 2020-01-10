using System.Collections.Generic;
using AzureFromTheTrenches.Commanding.Abstractions;
using ToDo.Application.Model;

namespace ToDo.Application.Commands
{
    public class GetAllToDoItemsQuery : ICommand<IReadOnlyCollection<ToDoItem>>
    {
        
    }
}