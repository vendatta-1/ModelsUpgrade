using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.POSCasher.POSValueObjs;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.POSCasher;

public class PosPaymentDaily : Entity
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long PaymentNo { get; set; }

    public Guid CompanyDataId { get; set; }

    public Guid BranchesDataId { get; set; }

    public Guid PossalesId { get; set; }

    public DateOnly? Date { get; set; }

    public Guid PaymentModesId { get; set; }

    public POSTransactionInfo TransactionInfo { get; set; }
    public bool? IsPosted { get; set; } = true;

    public virtual PaymentMode PaymentModes { get; set; }

    public virtual PosSale PosSales { get; set; }
}
