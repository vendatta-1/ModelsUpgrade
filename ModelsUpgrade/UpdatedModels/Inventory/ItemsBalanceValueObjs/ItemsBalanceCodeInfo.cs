using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Inventory.ItemsBalanceValueObjs
{
    [Owned]
    public record ItemsBalanceCodeInfo
    (
        string InternationalBarCode,
        string SupplierBarCode,
        string InternalCode
    );
}
