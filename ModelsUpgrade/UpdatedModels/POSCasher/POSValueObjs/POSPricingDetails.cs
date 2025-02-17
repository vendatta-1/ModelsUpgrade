using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.POSCasher.POSValueObjs
{
    [Owned]
    public record POSPricingDetails
    (
         double? TotalValue,

         double? TotalDiscounts,

         double? TaxTotals,

         double? NetValue
    );
}
