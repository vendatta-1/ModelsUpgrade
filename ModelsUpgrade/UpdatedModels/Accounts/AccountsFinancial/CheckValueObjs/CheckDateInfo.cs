using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial.CheckValueObjs
{
    [Owned]
    public record CheckDateInfo
    (

        int? Year,
        int? Month,
        DateOnly? CheckDate,
        DateOnly? DueDate,
        DateOnly? PaymentDate,
        DateOnly? CheckSignDate
    );
}
