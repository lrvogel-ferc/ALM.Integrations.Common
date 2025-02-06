using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALM.Integrations.Common.Config;

/// <summary>
/// This is the base class for all strongly-typed configuration objects that 
/// get instantiated from the <see cref="IConfiguration"/> properties.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <remarks>See AtmsWebApiConfig -- do NOT use config objects in Azure Functions</remarks>
public abstract class ConfigOptionsBase<T>
    where T: ConfigOptionsBase<T>, new()
{
    public abstract string SectionName { get; }

    public static T Construct(IConfiguration configuration)
    {
        var instance = new T();
        return configuration.GetSection(instance.SectionName).Get<T>()!;
    }
}
