using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Accounts.MoneySetting
{
    public abstract class MoneyEntity : Entity
    {
        #region FK
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }
        [ForeignKey(nameof(FromAccountName))]
        public Guid? FromAccountNameId { get; set; }
        [ForeignKey(nameof(ToAccountName))]

        public Guid? ToAccountNameId { get; set; }
        [ForeignKey(nameof(FromCash))]
        public Guid? FromCashId { get; set; }
        public Guid? CostCenterId { get; set; }
        #endregion

        #region Props
        [MaxLength(50)]
        public string PaperNumber { get; set; }
        public double? Value { get; set; }

        public DateOnly? Date { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }


        public bool? IsPosted { get; set; }
        #endregion

        #region NavigationProps
        public virtual CompanyData CompanyData { get; set; }

        public virtual CostCenter CostCenter { get; set; }

        public virtual AccountName FromAccountName { get; set; }

        public virtual AccountName FromCash { get; set; }

        public virtual AccountName ToAccountName { get; set; }
        public virtual BranchesData BranchesData { get; set; }  //
        #endregion

    }
}
