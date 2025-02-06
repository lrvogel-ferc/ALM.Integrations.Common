namespace ALM.Integrations.Common;
public class WorksetFERCOrganization
{
    public int Work_Set_FERC_Organization_id { get; set; }
    public int Work_Set_fk { get; set; }
    public string FERC_Organization_fk { get; set; }
    public bool Lead_FERC_Organization_Indicator { get; set; }
    public DateTime Active_date { get; set; }
    public DateTime Inactive_date { get; set; }
}

