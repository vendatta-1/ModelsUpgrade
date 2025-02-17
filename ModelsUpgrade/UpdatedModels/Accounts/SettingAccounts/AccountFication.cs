
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.Fixed;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;

public class AccountFication : NamedEntity
{

    public AccountFication(Guid id) : base(id)
    {
        AccountFixedDetails = new HashSet<AccountFixedDetail>();
        AccountNames = new HashSet<AccountName>();
        AccountsBalanceFooters = new HashSet<AccountsBalanceFooter>();
        FinancialCenters = new HashSet<FinancialCenter>();
    }
    protected AccountFication() { }
    public virtual ICollection<AccountFixedDetail> AccountFixedDetails { get; set; }

    public virtual ICollection<AccountName> AccountNames { get; set; }

    public virtual ICollection<AccountsBalanceFooter> AccountsBalanceFooters { get; set; }

    public virtual ICollection<FinancialCenter> FinancialCenters { get; set; }
}