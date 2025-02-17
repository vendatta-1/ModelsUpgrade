using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class WorkPlanFooter
{
    public Guid FooterId { get; set; }

    public Guid? WorkPlanHeaderId { get; set; }

    public int OrderNumberFooter { get; set; }

    public Guid? BankAtmid { get; set; }

    public int? OrderStatusId { get; set; }

    public byte? CounterForRejectTime { get; set; }

    public string AspNetUsersId { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AspNetUser AspNetUsers { get; set; }

    public virtual BankAtm BankAtm { get; set; }

    public virtual OrderStatus OrderStatus { get; set; }

    public virtual ICollection<WorkPlanComment> WorkPlanComments { get; set; } = new List<WorkPlanComment>();

    public virtual ICollection<WorkPlanDetail> WorkPlanDetails { get; set; } = new List<WorkPlanDetail>();

    public virtual WorkPlanHeader WorkPlanHeader { get; set; }
}
