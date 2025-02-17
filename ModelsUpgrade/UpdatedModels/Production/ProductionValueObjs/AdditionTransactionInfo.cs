namespace ModelsUpgrade.UpdatedModels.Production.ProductionValueObjs
{
    public record AdditionTransactionInfo
    {
        public double? UnitPrice { get; set; }

        public double? Quantity { get; set; }

        public double? TotalValue { get; set; }
    }
}
