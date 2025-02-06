namespace ALM.Integrations.Common;
public class CreateDocketRequest
{
    public Workset Workset { get; set; }
    public WorkItem Workitem { get; set; }
    public List<WorksetFERCOrganization> WorksetFERCOrganizations { get; set; }
    public List<object> RelatedWorksets { get; set; }
    public List<WorksetIndividualOrganization> WorksetIndividualOrganizations { get; set; }

}
