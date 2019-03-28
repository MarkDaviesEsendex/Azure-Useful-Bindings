using Microsoft.Azure.WebJobs.Host.Config;

namespace Bindings.Azure.WebJobs.Extensions.UsefulBindings
{
    internal class ConfigProvider : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            context.AddBindingRule<FromConfigAttribute>().BindToInput(GetString);
            context.AddBindingRule<IntFromConfigAttribute>().BindToInput(GetInt);
        }

        private static string GetString(FromConfigAttribute attribute)
            => attribute.Name;

        private static int GetInt(IntFromConfigAttribute attribute)
            => int.Parse(attribute.Name);

    }
}