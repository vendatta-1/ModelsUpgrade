using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.Shared
{
    [Owned]
    public record PurchaseInfo
    (
        double? Quantity = 0.0,
        double? Price = 0.0,
        double? Value = 0.0
    );
}
