using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Sales.SalesValueObjs
{
    [Owned]
    public record SalesInvoiceHeaderPricing
    {
        public double? TotalValue { get; set; }

        public double? TotalDiscounts { get; set; }

        public double? TotalAfterDiscounts { get; set; }

        public double? TaxTotals { get; set; }

        public double? NetValue { get; set; }
    }
}
