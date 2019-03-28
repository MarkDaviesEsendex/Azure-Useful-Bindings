# Azure-Useful-Bindings
A repository of useful bindings -maybe 

# What is this
Hopefully a collection of useful bindings for Azure functions

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
