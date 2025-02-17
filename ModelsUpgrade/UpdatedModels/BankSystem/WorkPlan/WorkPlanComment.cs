using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;
public class WorkPlanComment : Entity
{


    public Guid? WorkPlanFooterId { get; set; }
    [MaxLength(200)]
    public string Comment { get; set; }
    [MaxLength(200)]
    public string CommentDamag { get; set; }


    public virtual WorkPlanFooter WorkPlanFooter { get; set; }
}
