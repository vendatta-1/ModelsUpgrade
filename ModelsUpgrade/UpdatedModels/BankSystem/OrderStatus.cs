using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;

namespace ModelsUpgrade.UpdatedModels.BankSystem
{
    public class OrderStatus : NamedEntity
    {
        public virtual ICollection<WorkPlanFooter> WorkPlanFooters { get; set; } = new HashSet<WorkPlanFooter>();
    }

}
