using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;

public class AccountNature : NamedEntity
{
    public AccountNature(Guid id) : base(id)
    {

    }
    protected AccountNature()
    {

    }

    public virtual ICollection<AccountName> AccountNames { get; set; } = new HashSet<AccountName>();

    public virtual ICollection<CostCenter> CostCenters { get; set; } = new HashSet<CostCenter>();
}
