using Microsoft.Azure.WebJobs.Extensions.UsefulBindings;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(ConfigBindingsWebJobsStartup))]

namespace Microsoft.Azure.WebJobs.Extensions.UsefulBindings
{
    public class ConfigBindingsWebJobsStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<ConfigProvider>();
        }
    }
}