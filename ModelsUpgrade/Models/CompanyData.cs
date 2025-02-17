using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CompanyData
{
    public Guid CompanyId { get; set; }

    public int CompanyDataId { get; set; }

    public string CompanyName { get; set; }

    public string SpecializationL1 { get; set; }

    public string SpecializationL2 { get; set; }

    public TimeOnly? MorningTime1 { get; set; }

    public TimeOnly? MorningTime2 { get; set; }

    public TimeOnly? EveningPeriod1 { get; set; }

    public TimeOnly? EveningPeriod2 { get; set; }

    public long? ActivityCodeId { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string CompanyAddress { get; set; }

    public string BuildingNumber { get; set; }

    public string PostalCode { get; set; }

    public string FloorNumber { get; set; }

    public string RoomNumber { get; set; }

    public string LandMark { get; set; }

    public string AdditionalInformation { get; set; }

    public string CompanyMobil { get; set; }

    public string CompanyPhone { get; set; }

    public string CompanyWhatsapp { get; set; }

    public string CompanyEmail { get; set; }

    public string TaxRegistrationNumber { get; set; }

    public string TaxesErrand { get; set; }

    public string CommercialRegisterNumber { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AccountFiscalYear> AccountFiscalYears { get; set; } = new List<AccountFiscalYear>();

    public virtual ICollection<AccountFixedDetail> AccountFixedDetails { get; set; } = new List<AccountFixedDetail>();

    public virtual ICollection<AccountName> AccountNames { get; set; } = new List<AccountName>();

    public virtual ICollection<AccountsBalanceHeader> AccountsBalanceHeaders { get; set; } = new List<AccountsBalanceHeader>();

    public virtual ActivityCode ActivityCode { get; set; }

    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new List<ApplicationMenu>();

    public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; } = new List<ApplicationSetting>();

    public virtual ICollection<BankAtm> BankAtms { get; set; } = new List<BankAtm>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new List<BankCode>();

    public virtual ICollection<BranchesData> BranchesData { get; set; } = new List<BranchesData>();

    public virtual ICollection<BranchesList> BranchesLists { get; set; } = new List<BranchesList>();

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new List<CheckDetail>();

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<ConContractorDatum> ConContractorData { get; set; } = new List<ConContractorDatum>();

    public virtual ICollection<ConContractorExtractMaster> ConContractorExtractMasters { get; set; } = new List<ConContractorExtractMaster>();

    public virtual ICollection<ConProjectItem> ConProjectItems { get; set; } = new List<ConProjectItem>();

    public virtual ICollection<ConProjectsData> ConProjectsData { get; set; } = new List<ConProjectsData>();

    public virtual ICollection<CurrencySetting> CurrencySettings { get; set; } = new List<CurrencySetting>();

    public virtual ICollection<CustomerDatum> CustomerData { get; set; } = new List<CustomerDatum>();

    public virtual ICollection<DelegateDatum> DelegateData { get; set; } = new List<DelegateDatum>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new List<EduStudentPayment>();

    public virtual ICollection<FinancialCenter> FinancialCenters { get; set; } = new List<FinancialCenter>();

    public virtual ICollection<HotelPayment> HotelPayments { get; set; } = new List<HotelPayment>();

    public virtual ICollection<HotelRoomDatum> HotelRoomData { get; set; } = new List<HotelRoomDatum>();

    public virtual ICollection<HotelService> HotelServices { get; set; } = new List<HotelService>();

    public virtual ICollection<ItemsGroup> ItemsGroups { get; set; } = new List<ItemsGroup>();

    public virtual ICollection<JournalHeader> JournalHeaders { get; set; } = new List<JournalHeader>();

    public virtual ICollection<MoneyPayment> MoneyPayments { get; set; } = new List<MoneyPayment>();

    public virtual ICollection<MoneyReceive> MoneyReceives { get; set; } = new List<MoneyReceive>();

    public virtual ICollection<PItemsGroup> PitemsGroups { get; set; } = new List<PItemsGroup>();

    public virtual ICollection<ReservationDebit> ReservationDebits { get; set; } = new List<ReservationDebit>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new List<SupplierData>();

    public virtual ICollection<TransformationsMaster> TransformationsMasters { get; set; } = new List<TransformationsMaster>();

    public virtual ICollection<WhatsAppMessageData> WhatsAppMessageData { get; set; } = new List<WhatsAppMessageData>();

    public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new List<WorkPlanHeader>();
}
