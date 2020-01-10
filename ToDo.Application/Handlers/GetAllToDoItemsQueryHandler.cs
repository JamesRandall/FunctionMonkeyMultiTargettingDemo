using System.Collections.Generic;
using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using ToDo.Application.Commands;
using ToDo.Application.Model;
using ToDo.Application.Services;

namespace ToDo.Application.Handlers
{
    internal class GetAllToDoItemsQueryHandler : ICommandHandler<GetAllToDoItemsQuery, IReadOnlyCollection<ToDoItem>>
    {
        private readonly IRepository _repository;

        public GetAllToDoItemsQueryHandler(IRepository repository)
        {
            _repository = repository;
        }
        
        public Task<IReadOnlyCollection<ToDoItem>> ExecuteAsync(GetAllToDoItemsQuery command, IReadOnlyCollection<ToDoItem> previousResult)
        {
            return _repository.GetAll();
        }
    }
}