using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Application.Model;

namespace ToDo.Application.Services
{
    internal interface IRepository
    {
        Task<ToDoItem> Create(string title);

        Task MarkComplete(Guid id);

        Task<IReadOnlyCollection<ToDoItem>> GetAll();
    }
}