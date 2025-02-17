using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

namespace ModelsUpgrade.UpdatedModels.Inventory.InventorySetting
{
    public class BalanceName : NamedEntity
    {
        public BalanceName(Guid id) : base(id)
        {

        }
        protected BalanceName()
        {

        }
        public virtual ICollection<AccountsBalanceHeader> AccountsBalanceHeaders { get; set; } = new HashSet<AccountsBalanceHeader>();

        public virtual ICollection<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; } = new HashSet<ItemsBalanceHeader>();
    }
}
