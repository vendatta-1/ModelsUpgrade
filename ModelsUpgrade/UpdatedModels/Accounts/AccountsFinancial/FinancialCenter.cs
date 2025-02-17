using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial.FinancialCenterValueObjs;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
public class FinancialCenter : Entity
{


    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FinancialNo { get; set; }
    public Guid? CompanyDataId { get; set; }

    public Guid? AccountFicationId { get; set; }

    public Guid? AccountNameId { get; set; }

    public FinancialCenterTransactionInfo TransactionInfo { get; set; }


    public virtual AccountFication AccountFication { get; set; }

    public virtual AccountName AccountName { get; set; }

    public virtual CompanyData CompanyData { get; set; }
}
