using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts
{
    public class LockersData : NamedEntity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }
        public Guid? AccountNameId { get; set; }
        public virtual AccountName AccountName { get; set; }

        public virtual BranchesData BranchesData { get; set; }
        public virtual CompanyData CompanyData { get; set; }


    }
}
