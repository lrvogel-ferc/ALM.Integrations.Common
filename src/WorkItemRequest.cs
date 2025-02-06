using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ALM.Integrations.Common;
public class WorkItemRequest
{
    public Transaction Transaction { get; set; }

    [JsonPropertyName("Work_Set_Label")]
    public string WorkSetLabel { get; set; }
    [JsonPropertyName("FERC_Organization_fk")]
    public string FercOrgId { get; set; }
    [JsonPropertyName("Work_Item_Type_fk")]
    public int WorkItemType { get; set; }
    [JsonPropertyName("Work_Item_Name")]
    public string WorkItemName { get; set; }
    [JsonPropertyName("Work_Item_Desc")]
    public string WorkItemDesc { get; set; }
}
