using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ALM.Integrations.Common.AtmsWebApi;
/// <summary>
/// The request/response message for the CreateWorkItem API call.
/// </summary>
public class WorkItemRequestResponse
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
    [JsonPropertyName("Work_Item_id")]
    public string WorkItemId { get; set; }
    [JsonPropertyName("Completion_Code_fk")]
    public string CompletionCode { get; set; }
    [JsonPropertyName("Start_DateTime")]
    public DateTime Start { get; set; }
    [JsonPropertyName("Creation_DateTime")]
    public DateTime Creation { get; set; }
    [JsonPropertyName("Completion_DateTime")]
    public DateTime Completion { get; set; }
    [JsonPropertyName("Work_Item_Status_fk")]
    public string WorkItemStatusCd { get; set; }
    [JsonPropertyName("FERC_Organization_fk")]
    public string Org { get; set; }
    [JsonPropertyName("Statutory")]
    public bool Statutory { get; set; }
    [JsonPropertyName("Completion_Type_fk")]
    public string CompletionType { get; set; }
    [JsonPropertyName("Big_Ticket")]
    public bool BigTicket { get; set; }
    [JsonPropertyName("Work_Item_Sequence_Number")]
    public string SequenceNo { get; set; }
    [JsonPropertyName("Designation_Type_fk")]
    public string Designation { get; set; }
}
