using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AccountsBalanceHeader
{
    public Guid AccountsBalanceHeaderId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public DateOnly? StartDate { get; set; }

    public long? BalanceNameId { get; set; }

    public double? TotalDebit { get; set; }

    public double? TotalCredit { get; set; }

    public decimal? TotalBalance { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AccountsBalanceFooter> AccountsBalanceFooters { get; set; } = new List<AccountsBalanceFooter>();

    public virtual BalanceName BalanceName { get; set; }

    public virtual CompanyData CompanyData { get; set; }
}
