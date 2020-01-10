using System;
using System.Net.Http;
using FunctionMonkey.Abstractions;
using FunctionMonkey.Abstractions.Builders;
using Microsoft.Extensions.DependencyInjection;
using ToDo.Application.Commands;
using ToDo.Application.Services;

namespace ToDo.Application
{
    public class FunctionAppConfiguration : IFunctionAppConfiguration
    {
        public void Build(IFunctionHostBuilder builder)
        {
            builder
                .Setup((sc, cr) =>
                {
                    sc.AddSingleton<IRepository, Repository>();
                    cr.Discover<FunctionAppConfiguration>();
                })
                .Functions(functions => functions
                    .HttpRoute("todo", route => route
                        .HttpFunction<GetAllToDoItemsQuery>(HttpMethod.Get)
                        .HttpFunction<CreateToDoItemCommand>(HttpMethod.Post)
                        .HttpFunction<MarkToDoItemCompleteCommand>("/complete", HttpMethod.Put)
                    )
                )
                ;
        }
    }
}