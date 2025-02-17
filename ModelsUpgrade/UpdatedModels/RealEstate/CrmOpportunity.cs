using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class CrmOpportunity : NamedEntity
{


    public decimal Amount { get; set; }

    //public string Name { get; set; }

    public string UserId { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? StatusId { get; set; }

    public DateTime CloseDate { get; set; }

    public virtual CrmContact Contact { get; set; }


    public virtual ICollection<CrmTask> CrmTasks { get; set; } = new HashSet<CrmTask>();

    public virtual CrmOpportunityStatus Status { get; set; }
}
