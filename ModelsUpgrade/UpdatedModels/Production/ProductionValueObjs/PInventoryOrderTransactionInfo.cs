namespace ModelsUpgrade.UpdatedModels.Production.ProductionValueObjs
{
    public record PInventoryOrderTransactionInfo
    {
        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Value { get; set; }
    }
}
