
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.EInvoicing;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class PurchasesTaxInvoice : Entity
    {
        public PurchasesTaxInvoice(Guid id) : base(id) { }
        protected PurchasesTaxInvoice()
        {

        }
        public Guid? InvoicePurchasesFooterId { get; set; }

        public Guid? ReturnPurchasesFooterId { get; set; }

        public Guid? TaxableTypeId { get; set; }

        public double? TaxAmount { get; set; } = 0.0;

        public virtual PurchasesInvoiceFooter InvoicePurchasesFooter { get; set; }

        public virtual ReturnPurchasesFooter ReturnPurchasesFooter { get; set; }

        public virtual TaxableType TaxableType { get; set; }

    }
}
