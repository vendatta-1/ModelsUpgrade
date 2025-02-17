using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.POSCasher.POSValueObjs
{
    [Owned]
    public record POSTransactionInfo(
         double? Debit,
         double? Credit,
         double? Balance
    );
}
