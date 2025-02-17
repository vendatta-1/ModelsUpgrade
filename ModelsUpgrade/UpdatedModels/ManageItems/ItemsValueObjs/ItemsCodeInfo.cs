using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsValueObjs
{
    [Owned]
    public record ItemsCodeInfo
    (
        string InternationalBarCode,
        string SupplierBarCode,
        string InternalCode
    );
}
