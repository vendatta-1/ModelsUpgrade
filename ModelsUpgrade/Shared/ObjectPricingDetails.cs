using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.Shared
{
    [Owned]
    public record ObjectPricingDetails
    {
        public double? UnitPrice { get; set; } = 0.0;

        public double? Quantity { get; set; } = 0.0;

        public double? ItemValue { get; set; } = 0.0;

        public double? DiscountValue { get; set; } = 0.0;

        //public double? ValueAfterDiscount { get; set; }

        public double? TaxValue { get; set; } = 0.0;

        public double? NetValue { get; set; } = 0.0;

    }
}
