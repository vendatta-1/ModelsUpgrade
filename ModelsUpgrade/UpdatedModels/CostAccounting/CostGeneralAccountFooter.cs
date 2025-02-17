using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

namespace ModelsUpgrade.UpdatedModels.CostAccounting
{
    public class CostGeneralAccountFooter : TransactionFooterEntity
    {
        public Guid? JournalHeaderId { get; set; }

        public Guid? AccountNameId { get; set; }
        //public bool? IsPosted { get; set; }

        public virtual CostCenter AccountName { get; set; }

        public virtual CostGeneralAccountHeader JournalHeader { get; set; }
    }
}
