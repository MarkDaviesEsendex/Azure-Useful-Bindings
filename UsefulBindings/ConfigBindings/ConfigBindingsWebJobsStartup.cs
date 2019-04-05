using Bindings.Azure.WebJobs.Extensions.UsefulBindings;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(ConfigBindingsWebJobsStartup))]

namespace Bindings.Azure.WebJobs.Extensions.UsefulBindings
{
    public class ConfigBindingsWebJobsStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<ConfigProvider>();
//            builder.Services.AddSingleton(b => new HttpClient());
        }
    }
}