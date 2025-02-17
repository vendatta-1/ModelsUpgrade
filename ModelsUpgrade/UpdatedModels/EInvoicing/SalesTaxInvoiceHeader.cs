using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class SalesTaxInvoiceHeader : HeaderEntity
    {
        public Guid? SalesInvoiceHeaderId { get; set; }

        public Guid? ReturnSalesHeaderId { get; set; }

        public Guid? TaxableTypeId { get; set; }

        public double? TaxAmount { get; set; } = 0.0;

        public virtual ReturnSalesHeader ReturnSalesHeader { get; set; }

        public virtual SalesInvoiceHeader SalesInvoiceHeader { get; set; }

        public virtual TaxableType TaxableType { get; set; }
    }
}
