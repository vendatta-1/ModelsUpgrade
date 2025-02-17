using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;


namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;

public class AccountType : NamedEntity
{

    public virtual ICollection<AccountName> AccountNames { get; set; } = new HashSet<AccountName>();

    public virtual ICollection<CostCenter> CostCenters { get; set; } = new HashSet<CostCenter>();
}
