using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.CostAccounting;
using ModelsUpgrade.UpdatedModels.Education;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.Inventory;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.Medical;
using ModelsUpgrade.UpdatedModels.POSCasher;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.ProgramSetting;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.RealEstate;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.BasicInformation;
public class BranchesData : NamedEntity
{
    public BranchesData(Guid id) : base(id) { }
    protected BranchesData()
    {

    }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BranchesDataId { get; set; }



    //public string BranchName { get; set; }//instead of use one name change to use name l1 and l2

    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }
    public Guid? BranchTaxId { get; set; }

    public Guid? CompanyDataId { get; set; }

    [ForeignKey(nameof(BranchManager))]
    public Guid? BranchManagerId { get; set; }

    public string AdditionalInformation { get; set; }

    public ObjectCompleteAddress Address { get; set; }
    public ContactInfo BranchContactInfo { get; set; }

    public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new HashSet<AdditionAdjustment>();

    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new HashSet<ApplicationMenu>();

    public virtual EmployeeData BranchManager { get; set; }

    public virtual ICollection<BranchesList> BranchesLists { get; set; } = new HashSet<BranchesList>();

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<ClientDataToken> ClientDataTokens { get; set; } = new HashSet<ClientDataToken>();

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<CostCenter> CostCenters { get; set; } = new HashSet<CostCenter>();

    public virtual ICollection<CostGeneralAccountHeader> CostGeneralAccountHeaders { get; set; } = new HashSet<CostGeneralAccountHeader>();

    public virtual ICollection<CostJournalHeader> CostJournalHeaders { get; set; } = new HashSet<CostJournalHeader>();

    public virtual ICollection<EduAcademyCourse> EduAcademyCourses { get; set; } = new HashSet<EduAcademyCourse>();

    public virtual ICollection<EduQuestionsMaster> EduQuestionsMasters { get; set; } = new HashSet<EduQuestionsMaster>();

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new HashSet<EduStudentData>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new HashSet<EduStudentPayment>();

    public virtual ICollection<EmpGroupWork> EmpGroupWorks { get; set; } = new HashSet<EmpGroupWork>();

    public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();

    public virtual ICollection<GeneralAccountHeader> GeneralAccountHeaders { get; set; } = new HashSet<GeneralAccountHeader>();

    public virtual ICollection<InventoryOrderHeader> InventoryOrderHeaders { get; set; } = new HashSet<InventoryOrderHeader>();

    public virtual ICollection<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; } = new HashSet<ItemsBalanceHeader>();

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

    public virtual ICollection<LockersData> LockersData { get; set; } = new HashSet<LockersData>();

    public virtual ICollection<MedAnalysisName> MedAnalysisNames { get; set; } = new HashSet<MedAnalysisName>();

    public virtual ICollection<MedMedicalService> MedMedicalServices { get; set; } = new HashSet<MedMedicalService>();

    public virtual ICollection<MedPartnerData> MedPartnerData { get; set; } = new HashSet<MedPartnerData>();

    public virtual ICollection<MedRaysName> MedRaysNames { get; set; } = new HashSet<MedRaysName>();

    public virtual ICollection<MedSurgicalService> MedSurgicalServices { get; set; } = new HashSet<MedSurgicalService>();

    public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new HashSet<PAdditionAdjustment>();

    public virtual ICollection<PInventoryOrderHeader> PinventoryOrderHeaders { get; set; } = new HashSet<PInventoryOrderHeader>();

    public virtual ICollection<PItemsBalanceHeader> PitemsBalanceHeaders { get; set; } = new HashSet<PItemsBalanceHeader>();

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new HashSet<PItemsStock>();

    public virtual ICollection<PosMachine> Posmachines { get; set; } = new HashSet<PosMachine>();

    public virtual ICollection<PosSale> PosSales { get; set; } = new HashSet<PosSale>();

    public virtual ICollection<PosSession> PosSessions { get; set; } = new HashSet<PosSession>();

    public virtual ICollection<PPurchasesInvoiceHeader> PPurchasesInvoiceHeaders { get; set; } = new HashSet<PPurchasesInvoiceHeader>();

    public virtual ICollection<PRequestReceiptHeader> PRequestReceiptHeaders { get; set; } = new HashSet<PRequestReceiptHeader>();

    public virtual ICollection<PRequestReservationHeader> PRequestReservationHeaders { get; set; } = new HashSet<PRequestReservationHeader>();

    public virtual ICollection<PReturnPurchasesHeader> PReturnPurchasesHeaders { get; set; } = new HashSet<PReturnPurchasesHeader>();

    public virtual ICollection<PReturnReservationHeader> PReturnReservationHeaders { get; set; } = new HashSet<PReturnReservationHeader>();

    public virtual ICollection<PSettlementDiscount> PsettlementDiscounts { get; set; } = new HashSet<PSettlementDiscount>();

    public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new HashSet<PurchasesInvoiceHeader>();

    public virtual ICollection<PurchasesOrderHeader> PurchasesOrderHeaders { get; set; } = new HashSet<PurchasesOrderHeader>();

    public virtual ICollection<RequestReceiptHeader> RequestReceiptHeaders { get; set; } = new HashSet<RequestReceiptHeader>();

    public virtual ICollection<RequestReservationHeader> RequestReservationHeaders { get; set; } = new HashSet<RequestReservationHeader>();

    public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new HashSet<ReturnPurchasesHeader>();

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new HashSet<ReturnSalesHeader>();

    public virtual ICollection<RntActivity> RntActivities { get; set; } = new HashSet<RntActivity>();

    public virtual ICollection<RntContractsHeader> RntContractsHes { get; set; } = new HashSet<RntContractsHeader>();

    public virtual ICollection<RntCustomerPercentHeader> RntCustomerPercentHs { get; set; } = new HashSet<RntCustomerPercentHeader>();

    public virtual ICollection<RntExpenseType> RntExpenseTypes { get; set; } = new HashSet<RntExpenseType>();

    public virtual ICollection<RntExpense> RntExpenses { get; set; } = new HashSet<RntExpense>();

    public virtual ICollection<RntFloor> RntFloors { get; set; } = new HashSet<RntFloor>();

    public virtual ICollection<RntReceiptsHeader> RntReceiptsHes { get; set; } = new HashSet<RntReceiptsHeader>();

    public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new HashSet<SalesInvoiceHeader>();

    public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new HashSet<SettlementDiscount>();

    public virtual ICollection<StoreData> StoreData { get; set; } = new HashSet<StoreData>();
}
