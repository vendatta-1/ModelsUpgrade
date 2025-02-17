
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.MoneySetting;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.CostAccounting;
using ModelsUpgrade.UpdatedModels.CostAccounting.SettingAccounts.CostCenterValueObjs;
using ModelsUpgrade.UpdatedModels.Fixed;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial
{
    public class CostCenter : Entity
    {




        public Guid? ParentCodeId { get; set; }

        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? AccountTypeId { get; set; }

        public Guid? AccountMenuId { get; set; }

        public Guid? AccountNatureId { get; set; }

        public bool? NotMenu { get; set; }
        public CostCenterInformation CostInformation { get; set; }


        public virtual ICollection<AccountFixedDetail> AccountFixedDetails { get; set; } = new HashSet<AccountFixedDetail>();

        public virtual AccountMenu AccountMenu { get; set; }

        public virtual AccountNature AccountNature { get; set; }

        public virtual AccountType AccountType { get; set; }

        public virtual BranchesData BranchesData { get; set; }

        public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new HashSet<CheckDetail>();

        public virtual ICollection<CostGeneralAccountFooter> CostGeneralAccountFooters { get; set; } = new HashSet<CostGeneralAccountFooter>();

        public virtual ICollection<CostJournalFooter> CostJournalFooters { get; set; } = new HashSet<CostJournalFooter>();

        public virtual ICollection<GeneralAccountFooter> GeneralAccountFooters { get; set; } = new HashSet<GeneralAccountFooter>();

        public virtual ICollection<CostCenter> InverseParentCodeNavigation { get; set; } = new HashSet<CostCenter>();

        public virtual ICollection<JournalFooter> JournalFooters { get; set; } = new HashSet<JournalFooter>();

        public virtual ICollection<MoneyPayment> MoneyPayments { get; set; } = new HashSet<MoneyPayment>();

        public virtual ICollection<MoneyReceive> MoneyReceives { get; set; } = new HashSet<MoneyReceive>();

        public virtual CostCenter ParentCode { get; set; }
        public virtual CompanyData CompanyData { get; set; }

        public virtual ICollection<ReservationDebit> ReservationDebits { get; set; } = new HashSet<ReservationDebit>();
    }
}
