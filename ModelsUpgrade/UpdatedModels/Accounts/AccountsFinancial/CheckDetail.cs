using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial.CheckValueObjs;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;


public class CheckDetail : Entity
{



    public DateOnly? CheckDate { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CheckNumber { get; set; }

    public double? CheckValue { get; set; } = 0.0;


    public DateOnly? DueDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public DateOnly? CheckSignDate { get; set; }
    public CheckDateInfo? DateInfo { get; set; }
    [MaxLength(75)]
    public string CheckName { get; set; } = string.Empty;

    public int? NotifyDays { get; set; } = 0;
    [MaxLength(50)]
    public string CheckSiteName { get; set; }
    [MaxLength(50)]
    public string UnderlineCheck { get; set; }
    [MaxLength(50)]
    public string RepetitionTimes { get; set; }
    [MaxLength(250)]
    public string CheckImage { get; set; }

    public string Description { get; set; }

    public bool? IsPosted { get; set; } = true;
    public Guid? BankNameId { get; set; }

    public Guid? CostCenterId { get; set; }

    public Guid? CheckTypeId { get; set; }

    public Guid? AccountNameFromId { get; set; }

    public Guid? AccountNameToId { get; set; }

    public Guid? CheckStatusId { get; set; }

    public Guid? CurrencyDataId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }


    public virtual AccountName AccountNameFrom { get; set; }

    public virtual AccountName AccountNameTo { get; set; }

    public virtual BankCode BankName { get; set; }

    public virtual CheckStatus CheckStatus { get; set; }

    public virtual CheckType CheckType { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual BranchesData BranchesData { get; set; }
    public virtual CostCenter CostCenter { get; set; }

    public virtual CurrencyData CurrencyData { get; set; }
}
