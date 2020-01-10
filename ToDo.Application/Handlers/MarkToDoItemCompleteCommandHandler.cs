using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using ToDo.Application.Commands;
using ToDo.Application.Services;

namespace ToDo.Application.Handlers
{
    internal class MarkToDoItemCompleteCommandHandler : ICommandHandler<MarkToDoItemCompleteCommand>
    {
        private readonly IRepository _repository;

        public MarkToDoItemCompleteCommandHandler(IRepository repository)
        {
            _repository = repository;
        }
        
        public Task ExecuteAsync(MarkToDoItemCompleteCommand command)
        {
            return _repository.MarkComplete(command.Id);
        }
    }
}