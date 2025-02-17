
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BankSystem;
using ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.Sales;
using ModelsUpgrade.UpdatedModels.Security;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts
{
    public class BankCode : NamedEntity
    {
        public BankCode(Guid id) : base(id) { }
        protected BankCode() { }
        #region FK
        public Guid? CompanyDataId { get; set; }
        public Guid? CountryCodeId { get; set; }

        public Guid? GovernorateCodeId { get; set; }

        public Guid? CityCodeId { get; set; }
        public Guid? CurrencyDataId { get; set; }
        #endregion


        public ContactInfo Contacts { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; } = new HashSet<AppUser>();

        public virtual ICollection<BankAtm> BankAtms { get; set; } = new HashSet<BankAtm>();

        public virtual ICollection<BankContract> BankContracts { get; set; } = new HashSet<BankContract>();

        public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new HashSet<CheckDetail>();

        public virtual CityCode CityCode { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual CurrencyData CurrencyData { get; set; }

        public virtual GovernorateCode GovernorateCode { get; set; }
        public virtual CountryCode CountryCode { get; set; }//

        public virtual ICollection<SalesInvoicePayment> SalesInvoicePayments { get; set; } = new HashSet<SalesInvoicePayment>();

        public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new HashSet<WorkPlanHeader>();


    }
}
