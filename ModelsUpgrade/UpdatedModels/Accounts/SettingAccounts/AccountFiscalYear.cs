using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts
{
    public class AccountFiscalYear : NamedEntity
    {
        public AccountFiscalYear(Guid id) : base(id) { }
        protected AccountFiscalYear() { }
        public Guid? CompanyDataId { get; set; }
        public Duration? FiscalYearDuration { get; set; }

        public DateOnly? CloseDate { get; set; }

        public bool? IsClosed { get; set; }
        public virtual CompanyData CompanyData { get; set; }
    }
}
