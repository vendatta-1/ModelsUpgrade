
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial

{
    public class AccountsBalanceHeader : TransactionHeaderEntity
    {

        public AccountsBalanceHeader(Guid id) : base(id) { }
        protected AccountsBalanceHeader()
        {

        }

        public DateOnly? StartDate { get; set; }

        public Guid? BalanceNameId { get; set; }


        public virtual ICollection<AccountsBalanceFooter> AccountsBalanceFooters { get; set; } = new HashSet<AccountsBalanceFooter>();

        public virtual BalanceName BalanceName { get; set; }


    }
}
