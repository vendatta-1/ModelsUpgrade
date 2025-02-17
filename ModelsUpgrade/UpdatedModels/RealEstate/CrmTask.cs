using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class CrmTask : Entity
{

    public string Title { get; set; }

    public Guid OpportunityId { get; set; }

    public DateTime DueDate { get; set; }

    public Guid TypeId { get; set; }

    public Guid? StatusId { get; set; }

    public virtual CrmOpportunity Opportunity { get; set; }

    public virtual CrmTaskstatus Status { get; set; }

    public virtual CrmTaskType Type { get; set; }
}
