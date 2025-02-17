using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.CostAccounting;
using ModelsUpgrade.UpdatedModels.RealEstate;

namespace ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;

public class CurrencyData : NamedEntity
{

    public double? ExchangeRate { get; set; }
    public virtual ICollection<AccountName> AccountNames { get; set; } = new HashSet<AccountName>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new HashSet<BankCode>();

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new HashSet<CheckDetail>();

    public virtual ICollection<CostGeneralAccountHeader> CostGeneralAccountHeaders { get; set; } = new HashSet<CostGeneralAccountHeader>();

    public virtual ICollection<CostJournalHeader> CostJournalHeaders { get; set; } = new HashSet<CostJournalHeader>();

    //public virtual ICollection<CurrencySetting> CurrencySettings { get; set; } = new HashSet<CurrencySetting>();

    public virtual ICollection<JournalHeader> JournalHeaders { get; set; } = new HashSet<JournalHeader>();

    public virtual ICollection<RntReceiptsHeader> RntReceiptsHes { get; set; } = new HashSet<RntReceiptsHeader>();
}
