using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALM.Integrations.Common.Constants;

/// <summary>
/// NOTE: Configuration settings objects are NOT supported in Azure Functions. To use 
/// this kind of setup, point to an Azure App Configuration instance and pull configuration 
/// settings from there.
/// </summary>
public static class ConfigKeys
{
    public const string AtmsWebApiBaseUrl = nameof(AtmsWebApiBaseUrl);
    public const string DataverseUrl = nameof(DataverseUrl);
}
