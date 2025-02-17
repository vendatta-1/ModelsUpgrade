using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class PurchasesInvoiceDiscount : Entity
    {
        public PurchasesInvoiceDiscount(Guid id) : base(id)
        {

        }
        protected PurchasesInvoiceDiscount()
        {

        }
        public Guid? PurchasesInvoiceFooterId { get; set; }

        public Guid? ReturnPurchasesFooterId { get; set; }

        public Guid? DiscountTypeId { get; set; }

        public double? DiscountRate { get; set; } = 0.0;

        public double? DiscountAmount { get; set; } = 0.0;

        public virtual DiscountType DiscountType { get; set; }

        public virtual PurchasesInvoiceFooter PurchasesInvoiceFooter { get; set; }

        public virtual ReturnPurchasesFooter ReturnPurchasesFooter { get; set; }

    }



}
