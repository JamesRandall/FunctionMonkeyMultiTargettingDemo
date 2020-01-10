# Function Monkey Multi-Targetting Sample

This small sample demonstrates one of the ways you can target multiple hosts with a single codebase: Azure Functions and ASP.Net Core.

All the application code, including the API definition, is contained in the project ToDo.Application which follows the usual [Function Monkey approach](https://functionmonkey.azurefromthetrenches.com).

There are then two hosts ToDo.AspNetCore and ToDo.AzureFunctions. Each contain a public class that implements the IFunctionAppHost interface. These define the target in the CompileOptions section and specify that the function app configuraiton to use is the one in ToDo.Application.

When the Function Monkey compiler runs it will use this information to generate appropriate assemblies.

Note that this approach is entirely optional - you can also convert a project from one target type to the other - but it is a handy way of demonstrating the capabilities and cleanly separating code from the host environment (you'd have to specifically add ASP.Net Core assemblies to the application for example).