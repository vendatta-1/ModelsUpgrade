
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.Accounts.MoneySetting;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BankSystem;
using ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.BasicInformation.CompanyValueObjs;
using ModelsUpgrade.UpdatedModels.Contractors;
using ModelsUpgrade.UpdatedModels.Education;
using ModelsUpgrade.UpdatedModels.Fixed;
using ModelsUpgrade.UpdatedModels.HotelSetting;
using ModelsUpgrade.UpdatedModels.Inventory;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.ProgramSetting;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;
using ModelsUpgrade.UpdatedModels.WhatsApp;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.BasicInformation;
public class CompanyData : Entity
{
    public CompanyData(Guid id) : base(id) { }
    protected CompanyData() { }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CompanyDataId { get; set; }

    public Guid? ActivityCodeId { get; set; }

    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }
    public CompanyOpeningTime OpeningTime { get; set; }
    public ObjectCompleteAddress Address { get; set; }
    public ContactInfo ContactInformation { get; set; }
    public CompanyBasicInformation BasicInformation { get; set; }

    public virtual ICollection<AccountFiscalYear> AccountFiscalYears { get; set; } = new HashSet<AccountFiscalYear>();

    public virtual ICollection<AccountFixedDetail> AccountFixedDetails { get; set; } = new HashSet<AccountFixedDetail>();

    public virtual ICollection<AccountName> AccountNames { get; set; } = new HashSet<AccountName>();

    public virtual ICollection<AccountsBalanceHeader> AccountsBalanceHeaders { get; set; } = new HashSet<AccountsBalanceHeader>();

    public virtual ActivityCode ActivityCode { get; set; }

    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new HashSet<ApplicationMenu>();

    public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; } = new HashSet<ApplicationSetting>();

    public virtual ICollection<BankAtm> BankAtms { get; set; } = new HashSet<BankAtm>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new HashSet<BankCode>();

    public virtual ICollection<BranchesData> BranchesData { get; set; } = new HashSet<BranchesData>();

    public virtual ICollection<BranchesList> BranchesLists { get; set; } = new HashSet<BranchesList>();

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new HashSet<CheckDetail>();

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<ConContractorData> ConContractorData { get; set; } = new HashSet<ConContractorData>();

    public virtual ICollection<ConContractorExtractMaster> ConContractorExtractMasters { get; set; } = new HashSet<ConContractorExtractMaster>();

    public virtual ICollection<ConProjectItem> ConProjectItems { get; set; } = new HashSet<ConProjectItem>();

    public virtual ICollection<ConProjectsData> ConProjectsData { get; set; } = new HashSet<ConProjectsData>();

    //public virtual ICollection<CurrencySetting> CurrencySettings { get; set; } = new HashSet<CurrencySetting>();

    public virtual ICollection<CustomerData> CustomerData { get; set; } = new HashSet<CustomerData>();

    public virtual ICollection<DelegateData> DelegateData { get; set; } = new HashSet<DelegateData>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new HashSet<EduStudentPayment>();

    public virtual ICollection<FinancialCenter> FinancialCenters { get; set; } = new HashSet<FinancialCenter>();

    public virtual ICollection<HotelPayment> HotelPayments { get; set; } = new HashSet<HotelPayment>();

    public virtual ICollection<HotelRoomData> HotelRoomData { get; set; } = new HashSet<HotelRoomData>();

    public virtual ICollection<HotelService> HotelServices { get; set; } = new HashSet<HotelService>();

    public virtual ICollection<ItemsGroup> ItemsGroups { get; set; } = new HashSet<ItemsGroup>();

    public virtual ICollection<JournalHeader> JournalHeaders { get; set; } = new HashSet<JournalHeader>();

    public virtual ICollection<MoneyPayment> MoneyPayments { get; set; } = new HashSet<MoneyPayment>();

    public virtual ICollection<MoneyReceive> MoneyReceives { get; set; } = new HashSet<MoneyReceive>();

    public virtual ICollection<PItemsGroup> PitemsGroups { get; set; } = new HashSet<PItemsGroup>();

    public virtual ICollection<ReservationDebit> ReservationDebits { get; set; } = new HashSet<ReservationDebit>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new HashSet<SupplierData>();

    public virtual ICollection<TransformationsMaster> TransformationsMasters { get; set; } = new HashSet<TransformationsMaster>();

    public virtual ICollection<WhatsAppMessageData> WhatsAppMessageData { get; set; } = new HashSet<WhatsAppMessageData>();

    public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new HashSet<WorkPlanHeader>();
}
