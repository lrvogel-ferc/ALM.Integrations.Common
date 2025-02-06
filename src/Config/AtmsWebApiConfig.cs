namespace ALM.Integrations.Common.Config;
public class AtmsWebApiConfig : ConfigOptionsBase<AtmsWebApiConfig>
{
    public override string SectionName => "AtmsWebApi";

    /// <summary>
    /// The base URL for accessing the ATMS web api
    /// </summary>
    public string BaseUrl { get; set; }
}
