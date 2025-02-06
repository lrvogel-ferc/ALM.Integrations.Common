using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALM.Integrations.Common;
public class WorkItem
{

    public int Work_Item_id { get; set; }
    public string Work_Item_Name { get; set; }
    public string Work_Item_Desc { get; set; }
    public string Completion_Code_fk { get; set; }
    public DateTime Start_DateTime { get; set; }
    public DateTime Creation_DateTime { get; set; }
    public DateTime Completion_DateTime { get; set; }
    public string Work_Item_Status_fk { get; set; }
    public string FERC_Organization_fk { get; set; }
    public int Work_Item_Type_fk { get; set; }
    public bool Statutory { get; set; }
    public string Completion_Type_fk { get; set; }
    public bool Big_Ticket { get; set; }
    public string Work_Item_Sequence_Number { get; set; }
    public string Designation_Type_fk { get; set; }

}
