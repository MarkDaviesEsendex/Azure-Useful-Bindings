using System;
using Microsoft.Azure.WebJobs.Host.Config;

namespace Bindings.Azure.WebJobs.Extensions.UsefulBindings
{
    internal class ConfigProvider : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            context.AddBindingRule<FromConfigAttribute>().BindToInput(attr => attr.Name);
            context.AddBindingRule<IntFromConfigAttribute>().BindToInput(att => int.Parse(att.Name));
            context.AddBindingRule<UriFromConfigAttribute>().BindToInput(attr => new Uri(attr.Name));
        }
    }
}