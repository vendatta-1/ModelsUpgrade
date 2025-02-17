using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;

public class CheckType : NamedEntity
{

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new HashSet<CheckDetail>();
}
