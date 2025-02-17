using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Fixed
{
    public class AccountFixedDetail : NamedEntity
    {
        public AccountFixedDetail(Guid id) : base(id)
        { }
        protected AccountFixedDetail()
        {

        }
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? AccountFicationId { get; set; }

        public Guid? AccountNameId { get; set; }

        public Guid? AccountNameLevel2Id { get; set; }
        public DateOnly? BuyDate { get; set; }

        public string Location { get; set; }

        public string Responsible { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? BuyValue { get; set; } = 0;

        public short? Months { get; set; } = 0;

        public Guid? CostCenterId { get; set; }

        public double? Rate { get; set; } = 0.0;

        public DateOnly? LastUpdateDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CurrentValue { get; set; } = 0;

        public int? DepreciationAccId { get; set; } = 0;


        public virtual AccountFication AccountFication { get; set; }

        public virtual AccountName AccountName { get; set; }

        public virtual AccountName AccountNameLevel2 { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual CostCenter CostCenter { get; set; }
    }
}
