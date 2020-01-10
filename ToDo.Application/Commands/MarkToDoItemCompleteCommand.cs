using System;
using AzureFromTheTrenches.Commanding.Abstractions;

namespace ToDo.Application.Commands
{
    public class MarkToDoItemCompleteCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}