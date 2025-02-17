using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts.SettingAccountsValueObjs
{
    [Owned]
    public record AccountFiscalDateInfo
    {
        public DateOnly? DateFrom { get; set; }

        public DateOnly? DateTo { get; set; }

        public DateOnly? CloseDate { get; set; }
    }
}
