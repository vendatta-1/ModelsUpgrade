using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Inventory.ItemsBalanceValueObjs
{
    [Owned]
    public record ItemsBalancePurchaseInfo
    (
         double? ItemQuantity,

         double? ItemQuantityDamaged,

         double? ItemQuantityBroken,

         double? ItemPrice,

         double? ItemValue
    );
}
