namespace ModelsUpgrade.UpdatedModels.Production.ProductionValueObjs
{
    public record PPurchasesInvoicePricingDetails
    {
        public double? TotalValue { get; set; }

        public double? TotalDiscounts { get; set; }
        public double? TotalAfterDiscounts { get; set; }

        public double? TotalTaxs { get; set; }

        public double? NetValue { get; set; }
    }
}
