namespace ALM.Integrations.Common;
public class Workset
{
    public int Work_Set_id { get; set; }
    public string Work_Set_Label { get; set; }
    public string Work_Set_Short_Label { get; set; }
    public string Work_Set_Name { get; set; }
    public string Work_Set_Desc { get; set; }
    public int Project_fk { get; set; }
    public string Work_Set_Type_fk { get; set; }
    public string Work_Set_Year { get; set; }
    public string Work_Set_Sequence_Number { get; set; }
    public string Work_Set_Sub_Number { get; set; }
    public string Work_Set_Status_fk { get; set; }
    public int Class_fk { get; set; }
    public int Type_fk { get; set; }
    public int Lib_fk { get; set; }
    public int Cat_fk { get; set; }
    public int Docket_Prefix { get; set; }
    public DateTime Creation_Date { get; set; }
    public DateTime Completion_Date { get; set; }
    public DateTime Filing_Date { get; set; }
    public int Filing_Type { get; set; }
}
