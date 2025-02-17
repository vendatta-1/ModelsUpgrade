using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Purchasing.PurchasingValueObjs
{
    [Owned]
    public record ReturnPurchaseHeaderPrice
    {
        public double? TotalValue { get; set; }

        public double? TotalDiscounts { get; set; }

        public double? TotalTaxs { get; set; }

        public double? NetValue { get; set; }
    }
}
