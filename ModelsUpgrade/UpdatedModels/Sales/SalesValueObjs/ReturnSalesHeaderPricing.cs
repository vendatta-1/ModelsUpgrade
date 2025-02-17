namespace ModelsUpgrade.UpdatedModels.Sales.SalesValueObjs
{
    public record ReturnSalesHeaderPricing
    {
        public double? TotalValue { get; set; }

        public double? TotalDiscounts { get; set; }

        public double? TotalTaxs { get; set; }

        public double? NetValue { get; set; }
    }
}
