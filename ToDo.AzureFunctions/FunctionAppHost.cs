using FunctionMonkey.Abstractions;
using FunctionMonkey.Abstractions.Builders;
using FunctionMonkey.Compiler.Core;
using ToDo.Application;

namespace ToDo.AzureFunctions
{
    public class FunctionAppHost : IFunctionAppHost
    {
        public void Build(IFunctionAppHostBuilder builder)
        {
            builder
                .CompilerOptions(options => options
                    .HttpTarget(CompileTargetEnum.AzureFunctions)
                )
                .UseFunctionAppConfiguration<FunctionAppConfiguration>();
        }
    }
}