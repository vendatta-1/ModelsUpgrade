using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Security;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;

public class WorkPlanFooter : FooterEntity
{


    public Guid? WorkPlanHeaderId { get; set; }
    public Guid? BankAtmid { get; set; }

    public Guid? OrderStatusId { get; set; }


    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderNumberFooter { get; set; }

    public byte? CounterForRejectTime { get; set; }

    //public string AspNetUsersId { get; set; }


    public virtual AppUser AppUser { get; set; }/// / // need Id FK

    public virtual OrderStatus OrderStatus { get; set; }//

    public virtual ICollection<WorkPlanComment> WorkPlanComments { get; set; } = new HashSet<WorkPlanComment>();

    public virtual ICollection<WorkPlanDetail> WorkPlanDetails { get; set; } = new HashSet<WorkPlanDetail>();

    public virtual WorkPlanHeader WorkPlanHeader { get; set; }
}
