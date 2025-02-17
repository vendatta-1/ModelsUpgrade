using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;

public class WorkPlanDetail : Entity
{

    public Guid? WorkPlanFooterId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderNumberDetails { get; set; }
    [MaxLength(255)]
    public string ImagePath { get; set; }

    public int? ImageId { get; set; }

    public virtual WorkPlanFooter WorkPlanFooter { get; set; }
}
