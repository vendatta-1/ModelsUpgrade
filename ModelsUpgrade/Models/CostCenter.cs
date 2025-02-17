using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CostCenter
{
    public Guid CenterId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public long CostNumber { get; set; }

    public string CenterName { get; set; }

    public string Description { get; set; }

    public Guid? ParentCode { get; set; }

    public int? Levelcode { get; set; }

    public long? AccountTypeId { get; set; }

    public long? AccountMenuId { get; set; }

    public long? AccountNatureId { get; set; }

    public bool? NotMenu { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AccountFixedDetail> AccountFixedDetails { get; set; } = new List<AccountFixedDetail>();

    public virtual AccountMenu AccountMenu { get; set; }

    public virtual AccountNature AccountNature { get; set; }

    public virtual AccountType AccountType { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new List<CheckDetail>();

    public virtual ICollection<CostGeneralAccountFooter> CostGeneralAccountFooters { get; set; } = new List<CostGeneralAccountFooter>();

    public virtual ICollection<CostJournalFooter> CostJournalFooters { get; set; } = new List<CostJournalFooter>();

    public virtual ICollection<GeneralAccountFooter> GeneralAccountFooters { get; set; } = new List<GeneralAccountFooter>();

    public virtual ICollection<CostCenter> InverseParentCodeNavigation { get; set; } = new List<CostCenter>();

    public virtual ICollection<JournalFooter> JournalFooters { get; set; } = new List<JournalFooter>();

    public virtual ICollection<MoneyPayment> MoneyPayments { get; set; } = new List<MoneyPayment>();

    public virtual ICollection<MoneyReceive> MoneyReceives { get; set; } = new List<MoneyReceive>();

    public virtual CostCenter ParentCodeNavigation { get; set; }

    public virtual ICollection<ReservationDebit> ReservationDebits { get; set; } = new List<ReservationDebit>();
}
