using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class CrmTaskstatus : NamedEntity
{

    //public string Name { get; set; }

    public virtual ICollection<CrmTask> CrmTasks { get; set; } = new HashSet<CrmTask>();
}
