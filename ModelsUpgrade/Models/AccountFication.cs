using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AccountFication
{
    public long FicationId { get; set; }

    public string AccountFicationNameL1 { get; set; }

    public string AccountFicationNameL2 { get; set; }

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

    public virtual ICollection<AccountName> AccountNames { get; set; } = new List<AccountName>();

    public virtual ICollection<AccountsBalanceFooter> AccountsBalanceFooters { get; set; } = new List<AccountsBalanceFooter>();

    public virtual ICollection<FinancialCenter> FinancialCenters { get; set; } = new List<FinancialCenter>();
}
