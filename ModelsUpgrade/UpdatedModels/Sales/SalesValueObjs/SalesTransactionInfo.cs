using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Sales.SalesValueObjs
{
    [Owned]
    public record SalesTransactionInfo
    (
         double? Debit,
         double? Credit,
         double? Balance
    );
}
