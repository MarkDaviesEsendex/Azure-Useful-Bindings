# Azure-Useful-Bindings
A repository of useful bindings - maybe 

# What is this
Hopefully a collection of useful bindings for Azure functions

[![Build status](https://dev.azure.com/markdaviesesendex/AzureThings/_apis/build/status/AzureThings-ASP.NET%20Core-CI)](https://dev.azure.com/markdaviesesendex/AzureThings/_build/latest?definitionId=2)

![](https://img.shields.io/github/last-commit/MarkDaviesEsendex/Azure-Useful-Bindings.svg)

[![](https://img.shields.io/nuget/dt/Bindings.Azure.WebJobs.Extensions.UsefulBindings.svg)](https://www.nuget.org/packages/Bindings.Azure.WebJobs.Extensions.UsefulBindings/)


## Bindings

### From Config
Sometimes I just want to grab one or maybe two config settings from the `local.settings.json` but that means that I have to use `Environment.GetEnvironmentVariable` which immediately throws up alarm bells for me! It makes tests so much harder to write and a lot more secrative because somewhere in my test I now have to use `Environment.SetEnvironmentVariable` which I hate doing because it creates flakey tests - most test runners don't clear down environment variables which means that I now have to run tests syncronously. That's a massive headache just for one config value in a function!

Introducing `FromConfig`

```
public static class Function
{
    [FunctionName("Function")]
    public static void Run([FromConfig(Name = "ConfigSettingName")] string configValue)
    {
    }
}
```

Easy to use, it will take the setting name and bind it to a string value, I may extend this in future to do more types i.e. IntFromConfig, UriFromConfig, if there is enough interest.
