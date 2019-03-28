using Microsoft.Azure.WebJobs.Host.Config;

namespace Bindings.Azure.WebJobs.Extensions.UsefulBindings
{
    internal class ConfigProvider : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
            => context.AddBindingRule<FromConfigAttribute>().BindToInput(GetString);

        private static string GetString(FromConfigAttribute attribute)
            => attribute.Name;
    }
}