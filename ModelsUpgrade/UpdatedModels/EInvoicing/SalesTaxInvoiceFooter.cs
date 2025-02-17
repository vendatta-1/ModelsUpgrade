using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class SalesTaxInvoiceFooter : FooterEntity
    {
        public Guid? SalesInvoiceFooterId { get; set; }

        public Guid? ReturnSalesFooterId { get; set; }

        public Guid? TaxableTypeId { get; set; }

        public double? TaxAmount { get; set; } = 0.0;

        public Guid? ItemsHeaderId { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ReturnSalesFooter ReturnSalesFooter { get; set; }

        public virtual SalesInvoiceFooter SalesInvoiceFooter { get; set; }

        public virtual TaxableType TaxableType { get; set; }
    }
}
