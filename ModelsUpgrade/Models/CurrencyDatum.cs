using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CurrencyDatum
{
    public long CurrencyId { get; set; }

    public string CurrencyNameL1 { get; set; }

    public string CurrencyNameL2 { get; set; }

    public double? ExchangeRate { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AccountName> AccountNames { get; set; } = new List<AccountName>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new List<BankCode>();

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new List<CheckDetail>();

    public virtual ICollection<CostGeneralAccountHeader> CostGeneralAccountHeaders { get; set; } = new List<CostGeneralAccountHeader>();

    public virtual ICollection<CostJournalHeader> CostJournalHeaders { get; set; } = new List<CostJournalHeader>();

    public virtual ICollection<CurrencySetting> CurrencySettings { get; set; } = new List<CurrencySetting>();

    public virtual ICollection<JournalHeader> JournalHeaders { get; set; } = new List<JournalHeader>();

    public virtual ICollection<RntReceiptsHeader> RntReceiptsHes { get; set; } = new List<RntReceiptsHeader>();
}
