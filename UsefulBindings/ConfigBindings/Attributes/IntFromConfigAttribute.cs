using System;
using Microsoft.Azure.WebJobs.Description;

namespace Bindings.Azure.WebJobs.Extensions.UsefulBindings
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public sealed class IntFromConfigAttribute : Attribute
    {
        [AppSetting]
        public string Name { get; set; }
    }
}