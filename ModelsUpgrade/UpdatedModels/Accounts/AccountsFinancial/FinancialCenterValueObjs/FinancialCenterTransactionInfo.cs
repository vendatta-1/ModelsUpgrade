using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial.FinancialCenterValueObjs
{
    [Owned]
    public record FinancialCenterTransactionInfo
    {
        public double? Debit { get; set; }

        public double? Credit { get; set; }

        public double? TotalDebit { get; set; }

        public double? TotalCredit { get; set; }
    }
}
