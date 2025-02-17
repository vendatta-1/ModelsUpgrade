using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class CrmOpportunityStatus : NamedEntity
{

    //public string Name {  get; set; }
    public virtual ICollection<CrmOpportunity> CrmOpportunities { get; set; } = new HashSet<CrmOpportunity>();
}
