using FunctionMonkey.Abstractions;
using FunctionMonkey.Abstractions.Builders;
using FunctionMonkey.Compiler.Core;
using ToDo.Application;

namespace ToDo.AspNetCore
{
    public class FunctionAppHost : IFunctionAppHost
    {
        public void Build(IFunctionAppHostBuilder builder)
        {
            builder
                .CompilerOptions(options => options
                    .HttpTarget(CompileTargetEnum.AspNetCore)
                )
                .UseFunctionAppConfiguration<FunctionAppConfiguration>();
        }
    }
}