using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class BranchesData
{
    public Guid BranchId { get; set; }

    public int BranchesDataId { get; set; }

    public int? BranchTaxId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string BranchName { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string BranchAddress { get; set; }

    public string BuildingNumber { get; set; }

    public string PostalCode { get; set; }

    public string FloorNumber { get; set; }

    public string RoomNumber { get; set; }

    public string Landmark { get; set; }

    public string AdditionalInformation { get; set; }

    public string BranchMobil { get; set; }

    public string BranchPhone { get; set; }

    public string BranchWhatsapp { get; set; }

    public string BranchEmail { get; set; }

    public Guid? BranchManager { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new List<AdditionAdjustment>();

    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new List<ApplicationMenu>();

    public virtual EmployeeDatum BranchManagerNavigation { get; set; }

    public virtual ICollection<BranchesList> BranchesLists { get; set; } = new List<BranchesList>();

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<ClientDataToken> ClientDataTokens { get; set; } = new List<ClientDataToken>();

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<CostCenter> CostCenters { get; set; } = new List<CostCenter>();

    public virtual ICollection<CostGeneralAccountHeader> CostGeneralAccountHeaders { get; set; } = new List<CostGeneralAccountHeader>();

    public virtual ICollection<CostJournalHeader> CostJournalHeaders { get; set; } = new List<CostJournalHeader>();

    public virtual ICollection<EduAcademyCourse> EduAcademyCourses { get; set; } = new List<EduAcademyCourse>();

    public virtual ICollection<EduQuestionsMaster> EduQuestionsMasters { get; set; } = new List<EduQuestionsMaster>();

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new List<EduStudentData>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new List<EduStudentPayment>();

    public virtual ICollection<EmpGroupWork> EmpGroupWorks { get; set; } = new List<EmpGroupWork>();

    public virtual ICollection<EmployeeDatum> EmployeeData { get; set; } = new List<EmployeeDatum>();

    public virtual ICollection<GeneralAccountHeader> GeneralAccountHeaders { get; set; } = new List<GeneralAccountHeader>();

    public virtual ICollection<InventoryOrderHeader> InventoryOrderHeaders { get; set; } = new List<InventoryOrderHeader>();

    public virtual ICollection<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; } = new List<ItemsBalanceHeader>();

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual ICollection<LockersDatum> LockersData { get; set; } = new List<LockersDatum>();

    public virtual ICollection<MedAnalysisName> MedAnalysisNames { get; set; } = new List<MedAnalysisName>();

    public virtual ICollection<MedMedicalService> MedMedicalServices { get; set; } = new List<MedMedicalService>();

    public virtual ICollection<MedPartnerDatum> MedPartnerData { get; set; } = new List<MedPartnerDatum>();

    public virtual ICollection<MedRaysName> MedRaysNames { get; set; } = new List<MedRaysName>();

    public virtual ICollection<MedSurgicalService> MedSurgicalServices { get; set; } = new List<MedSurgicalService>();

    public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new List<PAdditionAdjustment>();

    public virtual ICollection<PInventoryOrderHeader> PinventoryOrderHeaders { get; set; } = new List<PInventoryOrderHeader>();

    public virtual ICollection<PItemsBalanceHeader> PitemsBalanceHeaders { get; set; } = new List<PItemsBalanceHeader>();

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new List<PItemsStock>();

    public virtual ICollection<Posmachine> Posmachines { get; set; } = new List<Posmachine>();

    public virtual ICollection<PosSale> Possales { get; set; } = new List<PosSale>();

    public virtual ICollection<Possession> Possessions { get; set; } = new List<Possession>();

    public virtual ICollection<PpurchasesInvoiceHeader> PpurchasesInvoiceHeaders { get; set; } = new List<PpurchasesInvoiceHeader>();

    public virtual ICollection<PrequestReceiptHeader> PrequestReceiptHeaders { get; set; } = new List<PrequestReceiptHeader>();

    public virtual ICollection<PrequestReservationHeader> PrequestReservationHeaders { get; set; } = new List<PrequestReservationHeader>();

    public virtual ICollection<PreturnPurchasesHeader> PreturnPurchasesHeaders { get; set; } = new List<PreturnPurchasesHeader>();

    public virtual ICollection<PreturnReservationHeader> PreturnReservationHeaders { get; set; } = new List<PreturnReservationHeader>();

    public virtual ICollection<PsettlementDiscount> PsettlementDiscounts { get; set; } = new List<PsettlementDiscount>();

    public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new List<PurchasesInvoiceHeader>();

    public virtual ICollection<PurchasesOrderHeader> PurchasesOrderHeaders { get; set; } = new List<PurchasesOrderHeader>();

    public virtual ICollection<RequestReceiptHeader> RequestReceiptHeaders { get; set; } = new List<RequestReceiptHeader>();

    public virtual ICollection<RequestReservationHeader> RequestReservationHeaders { get; set; } = new List<RequestReservationHeader>();

    public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new List<ReturnPurchasesHeader>();

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new List<ReturnSalesHeader>();

    public virtual ICollection<RntActivity> RntActivities { get; set; } = new List<RntActivity>();

    public virtual ICollection<RntContractsH> RntContractsHes { get; set; } = new List<RntContractsH>();

    public virtual ICollection<RntCustomerPercentH> RntCustomerPercentHs { get; set; } = new List<RntCustomerPercentH>();

    public virtual ICollection<RntExpenseType> RntExpenseTypes { get; set; } = new List<RntExpenseType>();

    public virtual ICollection<RntExpense> RntExpenses { get; set; } = new List<RntExpense>();

    public virtual ICollection<RntFloor> RntFloors { get; set; } = new List<RntFloor>();

    public virtual ICollection<RntReceiptsHeader> RntReceiptsHes { get; set; } = new List<RntReceiptsHeader>();

    public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new List<SalesInvoiceHeader>();

    public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new List<SettlementDiscount>();

    public virtual ICollection<StoreData> StoreData { get; set; } = new List<StoreData>();
}
