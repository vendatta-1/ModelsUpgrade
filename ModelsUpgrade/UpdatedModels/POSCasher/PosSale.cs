using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;
using ModelsUpgrade.UpdatedModels.POSCasher.POSValueObjs;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.POSCasher;
public class PosSale : Entity
{
    //public Guid InvoiceId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long InvoiceNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? BarcodeInvoice { get; set; }

    public DateInfo DateInfo { get; set; }

    public string Description { get; set; }

    public Guid? CustomerDataId { get; set; }

    public Guid? PriceTypeId { get; set; }

    public POSPricingDetails PricingDetails { get; set; }

    public bool? IsPosted { get; set; } = true;


    public virtual BranchesData BranchesData { get; set; }

    public virtual CustomerData CustomerData { get; set; }

    public virtual ICollection<PosPaymentDaily> PospaymentDailies { get; set; } = new HashSet<PosPaymentDaily>();

    public virtual ICollection<PosSalesDetail> PossalesDetails { get; set; } = new HashSet<PosSalesDetail>();

    public virtual PriceType PriceType { get; set; }
}
