
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting
{
    public class DiscountType : NamedEntity
    {
        public double? DiscountValue { get; set; }

        public double? DiscountPercent { get; set; }
        public virtual ICollection<PurchasesInvoiceDiscount> PurchasesInvoiceDiscounts { get; set; } = new HashSet<PurchasesInvoiceDiscount>();

        public virtual ICollection<SalesInvoiceDiscount> SalesInvoiceDiscounts { get; set; } = new HashSet<SalesInvoiceDiscount>();
    }
}
