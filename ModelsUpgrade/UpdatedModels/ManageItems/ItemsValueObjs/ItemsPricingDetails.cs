using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsValueObjs
{
    [Owned]
    public record ItemsPricingDetails
    (
         int? StockLimit,

         double? ItemPricePurchase,

         double? ItemPriceCost,

         double? ItemProfit1,

         double? ItemPrice1,

         double? ItemPrice2,

         double? ItemPrice3,
         double? ItemPrice4,

         double? ItemPrice5

    );
}
