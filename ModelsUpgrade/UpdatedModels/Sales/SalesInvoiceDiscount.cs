using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class SalesInvoiceDiscount : Entity
    {
        public Guid? SalesInvoiceFooterId { get; set; }

        public Guid? ReturnSalesFooterId { get; set; }

        public Guid? DiscountTypeId { get; set; }

        public double? DiscountRate { get; set; }

        public double? DiscountAmount { get; set; }

        public virtual SalesInvoiceFooter DiscountInvoice { get; set; }

        public virtual DiscountType DiscountType { get; set; }

        public virtual ReturnSalesFooter ReturnSalesFooter { get; set; }
    }
}
