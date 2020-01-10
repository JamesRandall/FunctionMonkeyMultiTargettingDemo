using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using ToDo.Application.Commands;
using ToDo.Application.Model;
using ToDo.Application.Services;

namespace ToDo.Application.Handlers
{
    internal class CreateToDoItemCommandHandler : ICommandHandler<CreateToDoItemCommand, ToDoItem>
    {
        private readonly IRepository _repository;

        public CreateToDoItemCommandHandler(IRepository repository)
        {
            _repository = repository;
        }
        
        public Task<ToDoItem> ExecuteAsync(CreateToDoItemCommand command, ToDoItem previousResult)
        {
            return _repository.Create(command.Title);
        }
    }
}