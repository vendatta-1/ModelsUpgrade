using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ModelsUpgrade.UpdatedModels.Contractors;

namespace Link_Entities.Models;

public partial class LinkSoftContext : DbContext
{
    public LinkSoftContext()
    {
    }

    public LinkSoftContext(DbContextOptions<LinkSoftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountFication> AccountFications { get; set; }

    public virtual DbSet<AccountFiscalYear> AccountFiscalYears { get; set; }

    public virtual DbSet<AccountFixedDetail> AccountFixedDetails { get; set; }

    public virtual DbSet<AccountMenu> AccountMenus { get; set; }

    public virtual DbSet<AccountName> AccountNames { get; set; }

    public virtual DbSet<AccountNature> AccountNatures { get; set; }

    public virtual DbSet<AccountType> AccountTypes { get; set; }

    public virtual DbSet<AccountsBalanceFooter> AccountsBalanceFooters { get; set; }

    public virtual DbSet<AccountsBalanceHeader> AccountsBalanceHeaders { get; set; }

    public virtual DbSet<ActivityCode> ActivityCodes { get; set; }

    public virtual DbSet<AdditionAdjustment> AdditionAdjustments { get; set; }

    public virtual DbSet<ApiurltaxServer> ApiurltaxServers { get; set; }

    public virtual DbSet<ApplicationMenu> ApplicationMenus { get; set; }

    public virtual DbSet<ApplicationMessage> ApplicationMessages { get; set; }

    public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<AspPermission> AspPermissions { get; set; }

    public virtual DbSet<AttachmentFile> AttachmentFiles { get; set; }

    public virtual DbSet<AttachmentFilesType> AttachmentFilesTypes { get; set; }

    public virtual DbSet<BalanceName> BalanceNames { get; set; }

    public virtual DbSet<BankAtm> BankAtms { get; set; }

    public virtual DbSet<BankCode> BankCodes { get; set; }

    public virtual DbSet<BankContract> BankContracts { get; set; }

    public virtual DbSet<BranchList> BranchLists { get; set; }

    public virtual DbSet<BranchesData> BranchesData { get; set; }

    public virtual DbSet<BranchesList> BranchesLists { get; set; }

    public virtual DbSet<BranchesSale> BranchesSales { get; set; }

    public virtual DbSet<CheckDetail> CheckDetails { get; set; }

    public virtual DbSet<CheckStatus> CheckStatuses { get; set; }

    public virtual DbSet<CheckType> CheckTypes { get; set; }

    public virtual DbSet<CityCode> CityCodes { get; set; }

    public virtual DbSet<ClientAccessToken> ClientAccessTokens { get; set; }

    public virtual DbSet<ClientDataToken> ClientDataTokens { get; set; }

    public virtual DbSet<ColorType> ColorTypes { get; set; }

    public virtual DbSet<CompanyData> CompanyData { get; set; }

    public virtual DbSet<ConContractorDatum> ConContractorData { get; set; }

    public virtual DbSet<ConContractorExtractDetail> ConContractorExtractDetails { get; set; }

    public virtual DbSet<ConContractorExtractMaster> ConContractorExtractMasters { get; set; }

    public virtual DbSet<ConProjectItem> ConProjectItems { get; set; }

    public virtual DbSet<ConProjectsData> ConProjectsData { get; set; }

    public virtual DbSet<CostCenter> CostCenters { get; set; }

    public virtual DbSet<CostGeneralAccountFooter> CostGeneralAccountFooters { get; set; }

    public virtual DbSet<CostGeneralAccountHeader> CostGeneralAccountHeaders { get; set; }

    public virtual DbSet<CostJournalFooter> CostJournalFooters { get; set; }

    public virtual DbSet<CostJournalHeader> CostJournalHeaders { get; set; }

    public virtual DbSet<CountryCode> CountryCodes { get; set; }

    public virtual DbSet<CrmContact> CrmContacts { get; set; }

    public virtual DbSet<CrmOpportunity> CrmOpportunities { get; set; }

    public virtual DbSet<CrmOpportunityStatus> CrmOpportunityStatuses { get; set; }

    public virtual DbSet<CrmTask> CrmTasks { get; set; }

    public virtual DbSet<CrmTaskType> CrmTaskTypes { get; set; }

    public virtual DbSet<CrmTaskstatus> CrmTaskstatuses { get; set; }

    public virtual DbSet<CurrencyDatum> CurrencyData { get; set; }

    public virtual DbSet<CurrencySetting> CurrencySettings { get; set; }

    public virtual DbSet<CustomerCategory> CustomerCategories { get; set; }

    public virtual DbSet<CustomerDatum> CustomerData { get; set; }

    public virtual DbSet<CustomerMode> CustomerModes { get; set; }

    public virtual DbSet<DatabaseDescription> DatabaseDescriptions { get; set; }

    public virtual DbSet<DelegateDatum> DelegateData { get; set; }

    public virtual DbSet<DeliveryMode> DeliveryModes { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DeviceCode> DeviceCodes { get; set; }

    public virtual DbSet<DiscountType> DiscountTypes { get; set; }

    public virtual DbSet<DocumentsMode> DocumentsModes { get; set; }

    public virtual DbSet<EduAcademyCourse> EduAcademyCourses { get; set; }

    public virtual DbSet<EduQuestionDetail> EduQuestionDetails { get; set; }

    public virtual DbSet<EduQuestionType> EduQuestionTypes { get; set; }

    public virtual DbSet<EduQuestionsMaster> EduQuestionsMasters { get; set; }

    public virtual DbSet<EduStudentCourse> EduStudentCourses { get; set; }

    public virtual DbSet<EduStudentDatum> EduStudentData { get; set; }

    public virtual DbSet<EduStudentPayment> EduStudentPayments { get; set; }

    public virtual DbSet<EduStudentQuestion> EduStudentQuestions { get; set; }

    public virtual DbSet<EducationDatum> EducationData { get; set; }

    public virtual DbSet<EducationeStimate> EducationeStimates { get; set; }

    public virtual DbSet<EmpAccept> EmpAccepts { get; set; }

    public virtual DbSet<EmpAcceptType> EmpAcceptTypes { get; set; }

    public virtual DbSet<EmpAttend> EmpAttends { get; set; }

    public virtual DbSet<EmpAttendType> EmpAttendTypes { get; set; }

    public virtual DbSet<EmpContractDetali> EmpContractDetalis { get; set; }

    public virtual DbSet<EmpContractMaster> EmpContractMasters { get; set; }

    public virtual DbSet<EmpContractType> EmpContractTypes { get; set; }

    public virtual DbSet<EmpDayWeek> EmpDayWeeks { get; set; }

    public virtual DbSet<EmpElementDatum> EmpElementData { get; set; }

    public virtual DbSet<EmpElementNature> EmpElementNatures { get; set; }

    public virtual DbSet<EmpElementType> EmpElementTypes { get; set; }

    public virtual DbSet<EmpGroupWork> EmpGroupWorks { get; set; }

    public virtual DbSet<EmpLevel> EmpLevels { get; set; }

    public virtual DbSet<EmpLevelType> EmpLevelTypes { get; set; }

    public virtual DbSet<EmpLoan> EmpLoans { get; set; }

    public virtual DbSet<EmpLoansType> EmpLoansTypes { get; set; }

    public virtual DbSet<EmployeeCourse> EmployeeCourses { get; set; }

    public virtual DbSet<EmployeeDatum> EmployeeData { get; set; }

    public virtual DbSet<EmployeeJob> EmployeeJobs { get; set; }

    public virtual DbSet<EmployeeSkill> EmployeeSkills { get; set; }

    public virtual DbSet<FinalDataFixed> FinalDataFixeds { get; set; }

    public virtual DbSet<FinalDatum> FinalData { get; set; }

    public virtual DbSet<FinancialCenter> FinancialCenters { get; set; }

    public virtual DbSet<GenderDatum> GenderData { get; set; }

    public virtual DbSet<GeneralAccountFooter> GeneralAccountFooters { get; set; }

    public virtual DbSet<GeneralAccountHeader> GeneralAccountHeaders { get; set; }

    public virtual DbSet<GeneralAccountType> GeneralAccountTypes { get; set; }

    public virtual DbSet<GovernorateCode> GovernorateCodes { get; set; }

    public virtual DbSet<HomePage> HomePages { get; set; }

    public virtual DbSet<HotelPayment> HotelPayments { get; set; }

    public virtual DbSet<HotelReservationDetail> HotelReservationDetails { get; set; }

    public virtual DbSet<HotelReservationMaster> HotelReservationMasters { get; set; }

    public virtual DbSet<HotelRoomDatum> HotelRoomData { get; set; }

    public virtual DbSet<HotelService> HotelServices { get; set; }

    public virtual DbSet<InstallmentFooter> InstallmentFooters { get; set; }

    public virtual DbSet<InstallmentHeader> InstallmentHeaders { get; set; }

    public virtual DbSet<InventoryOrderFooter> InventoryOrderFooters { get; set; }

    public virtual DbSet<InventoryOrderHeader> InventoryOrderHeaders { get; set; }

    public virtual DbSet<InventoryValuation> InventoryValuations { get; set; }

    public virtual DbSet<InvoicingResult> InvoicingResults { get; set; }

    public virtual DbSet<ItemsBalancFooter> ItemsBalancFooters { get; set; }

    public virtual DbSet<ItemsBalanceFooter> ItemsBalanceFooters { get; set; }

    public virtual DbSet<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; }

    public virtual DbSet<ItemsCodeType> ItemsCodeTypes { get; set; }

    public virtual DbSet<ItemsColor> ItemsColors { get; set; }

    public virtual DbSet<ItemsGroup> ItemsGroups { get; set; }

    public virtual DbSet<ItemsHeader> ItemsHeaders { get; set; }

    public virtual DbSet<ItemsPricePurchase> ItemsPricePurchases { get; set; }

    public virtual DbSet<ItemsPricePurchasesSupplier> ItemsPricePurchasesSuppliers { get; set; }

    public virtual DbSet<ItemsPriceSale> ItemsPriceSales { get; set; }

    public virtual DbSet<ItemsPriceSalesMenu> ItemsPriceSalesMenus { get; set; }

    public virtual DbSet<ItemsProduction> ItemsProductions { get; set; }

    public virtual DbSet<ItemsSize> ItemsSizes { get; set; }

    public virtual DbSet<ItemsStock> ItemsStocks { get; set; }

    public virtual DbSet<ItemsType> ItemsTypes { get; set; }

    public virtual DbSet<JobDatum> JobData { get; set; }

    public virtual DbSet<JournalEntriesType> JournalEntriesTypes { get; set; }

    public virtual DbSet<JournalFooter> JournalFooters { get; set; }

    public virtual DbSet<JournalHeader> JournalHeaders { get; set; }

    public virtual DbSet<Key> Keys { get; set; }

    public virtual DbSet<LockersBalance> LockersBalances { get; set; }

    public virtual DbSet<LockersDatum> LockersData { get; set; }

    public virtual DbSet<MedAnalysisName> MedAnalysisNames { get; set; }

    public virtual DbSet<MedCustomerDetail> MedCustomerDetails { get; set; }

    public virtual DbSet<MedCustomerMedicalService> MedCustomerMedicalServices { get; set; }

    public virtual DbSet<MedCustomerSurgicalService> MedCustomerSurgicalServices { get; set; }

    public virtual DbSet<MedMedicalService> MedMedicalServices { get; set; }

    public virtual DbSet<MedPartnerDatum> MedPartnerData { get; set; }

    public virtual DbSet<MedRaysName> MedRaysNames { get; set; }

    public virtual DbSet<MedSurgicalService> MedSurgicalServices { get; set; }

    public virtual DbSet<MoneyPayment> MoneyPayments { get; set; }

    public virtual DbSet<MoneyReceive> MoneyReceives { get; set; }

    public virtual DbSet<Month> Months { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<PAdditionAdjustment> PadditionAdjustments { get; set; }

    public virtual DbSet<PaymentMode> PaymentModes { get; set; }

    public virtual DbSet<PersistedGrant> PersistedGrants { get; set; }

    public virtual DbSet<PInventoryOrderFooter> PinventoryOrderFooters { get; set; }

    public virtual DbSet<PInventoryOrderHeader> PinventoryOrderHeaders { get; set; }

    public virtual DbSet<PItemsBalanceFooter> PitemsBalanceFooters { get; set; }

    public virtual DbSet<PItemsBalanceHeader> PitemsBalanceHeaders { get; set; }

    public virtual DbSet<PItemsGroup> PitemsGroups { get; set; }

    public virtual DbSet<PItemsHeader> PitemsHeaders { get; set; }

    public virtual DbSet<PItemsStock> PitemsStocks { get; set; }

    public virtual DbSet<Posmachine> Posmachines { get; set; }

    public virtual DbSet<PospaymentDaily> PospaymentDailies { get; set; }

    public virtual DbSet<PosSale> Possales { get; set; }

    public virtual DbSet<PossalesDetail> PossalesDetails { get; set; }

    public virtual DbSet<PossalesDiscount> PossalesDiscounts { get; set; }

    public virtual DbSet<Possession> Possessions { get; set; }

    public virtual DbSet<PPurchasesInvoiceFooter> PpurchasesInvoiceFooters { get; set; }

    public virtual DbSet<PpurchasesInvoiceHeader> PpurchasesInvoiceHeaders { get; set; }

    public virtual DbSet<PRequestReceiptFooter> PrequestReceiptFooters { get; set; }

    public virtual DbSet<PrequestReceiptHeader> PrequestReceiptHeaders { get; set; }

    public virtual DbSet<PRequestReservationFooter> PrequestReservationFooters { get; set; }

    public virtual DbSet<PrequestReservationHeader> PrequestReservationHeaders { get; set; }

    public virtual DbSet<PReturnPurchasesFooter> PreturnPurchasesFooters { get; set; }

    public virtual DbSet<PreturnPurchasesHeader> PreturnPurchasesHeaders { get; set; }

    public virtual DbSet<PReturnReservationFooter> PreturnReservationFooters { get; set; }

    public virtual DbSet<PreturnReservationHeader> PreturnReservationHeaders { get; set; }

    public virtual DbSet<PriceType> PriceTypes { get; set; }

    public virtual DbSet<ProgramOption> ProgramOptions { get; set; }

    public virtual DbSet<PsettlementDiscount> PsettlementDiscounts { get; set; }

    public virtual DbSet<PurchasesInvoiceDiscount> PurchasesInvoiceDiscounts { get; set; }

    public virtual DbSet<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; }

    public virtual DbSet<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; }

    public virtual DbSet<PurchasesOrderFooter> PurchasesOrderFooters { get; set; }

    public virtual DbSet<PurchasesOrderHeader> PurchasesOrderHeaders { get; set; }

    public virtual DbSet<PurchasesTaxInvoice> PurchasesTaxInvoices { get; set; }

    public virtual DbSet<RecruitmentDatum> RecruitmentData { get; set; }

    public virtual DbSet<ReportViewWorkPlan> ReportViewWorkPlans { get; set; }

    public virtual DbSet<ReportsName> ReportsNames { get; set; }

    public virtual DbSet<RequestReceiptFooter> RequestReceiptFooters { get; set; }

    public virtual DbSet<RequestReceiptHeader> RequestReceiptHeaders { get; set; }

    public virtual DbSet<RequestReservationFooter> RequestReservationFooters { get; set; }

    public virtual DbSet<RequestReservationHeader> RequestReservationHeaders { get; set; }

    public virtual DbSet<ReservationDebit> ReservationDebits { get; set; }

    public virtual DbSet<ReservationStatus> ReservationStatuses { get; set; }

    public virtual DbSet<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; }

    public virtual DbSet<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; }

    public virtual DbSet<ReturnSalesFooter> ReturnSalesFooters { get; set; }

    public virtual DbSet<ReturnSalesHeader> ReturnSalesHeaders { get; set; }

    public virtual DbSet<RntActivity> RntActivities { get; set; }

    public virtual DbSet<RntContractsD> RntContractsDs { get; set; }

    public virtual DbSet<RntContractsH> RntContractsHes { get; set; }

    public virtual DbSet<RntCustomerPercentD> RntCustomerPercentDs { get; set; }

    public virtual DbSet<RntCustomerPercentH> RntCustomerPercentHs { get; set; }

    public virtual DbSet<RntExpense> RntExpenses { get; set; }

    public virtual DbSet<RntExpenseType> RntExpenseTypes { get; set; }

    public virtual DbSet<RntFloor> RntFloors { get; set; }

    public virtual DbSet<RntReceiptsD> RntReceiptsDs { get; set; }

    public virtual DbSet<RntReceiptsHeader> RntReceiptsHes { get; set; }

    public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }

    public virtual DbSet<SalesInvoiceDelivery> SalesInvoiceDeliveries { get; set; }

    public virtual DbSet<SalesInvoiceDiscount> SalesInvoiceDiscounts { get; set; }

    public virtual DbSet<SalesInvoiceFooter> SalesInvoiceFooters { get; set; }

    public virtual DbSet<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; }

    public virtual DbSet<SalesInvoicePayment> SalesInvoicePayments { get; set; }

    public virtual DbSet<SalesInvoicesDelivery> SalesInvoicesDeliveries { get; set; }

    public virtual DbSet<SalesTaxInvoiceF> SalesTaxInvoiceFs { get; set; }

    public virtual DbSet<SalesTaxInvoiceH> SalesTaxInvoiceHs { get; set; }

    public virtual DbSet<ServerType> ServerTypes { get; set; }

    public virtual DbSet<SettlementDiscount> SettlementDiscounts { get; set; }

    public virtual DbSet<SizeType> SizeTypes { get; set; }

    public virtual DbSet<SocialDatum> SocialData { get; set; }

    public virtual DbSet<StatusDatum> StatusData { get; set; }

    public virtual DbSet<StokSalesInvoice> StokSalesInvoices { get; set; }

    public virtual DbSet<StoreData> StoreData { get; set; }

    public virtual DbSet<SupplierData> SupplierData { get; set; }

    public virtual DbSet<SupplierGroup> SupplierGroups { get; set; }

    public virtual DbSet<TaxableType> TaxableTypes { get; set; }

    public virtual DbSet<TransformationsDetail> TransformationsDetails { get; set; }

    public virtual DbSet<TransformationsMaster> TransformationsMasters { get; set; }

    public virtual DbSet<UnitType> UnitTypes { get; set; }

    public virtual DbSet<UniversityDatum> UniversityData { get; set; }

    public virtual DbSet<UserStatisticForOrderStatus> UserStatisticForOrderStatuses { get; set; }

    public virtual DbSet<ViewAccountsBalance> ViewAccountsBalances { get; set; }

    public virtual DbSet<ViewAspNetUser> ViewAspNetUsers { get; set; }

    public virtual DbSet<ViewBankAtmorder> ViewBankAtmorders { get; set; }

    public virtual DbSet<ViewCompanyUser> ViewCompanyUsers { get; set; }

    public virtual DbSet<ViewImageComment> ViewImageComments { get; set; }

    public virtual DbSet<ViewItemsGroup> ViewItemsGroups { get; set; }

    public virtual DbSet<ViewItemsGroupItemsHeader> ViewItemsGroupItemsHeaders { get; set; }

    public virtual DbSet<ViewPlanWorkWeb> ViewPlanWorkWebs { get; set; }

    public virtual DbSet<ViewSelectJournal> ViewSelectJournals { get; set; }

    public virtual DbSet<ViewSelectReportOwner> ViewSelectReportOwners { get; set; }

    public virtual DbSet<ViewSelectReportWorkPlan> ViewSelectReportWorkPlans { get; set; }

    public virtual DbSet<ViewWorkPlanOrderNew> ViewWorkPlanOrderNews { get; set; }

    public virtual DbSet<WhatsAppCompanyData> WhatsAppCompanyData { get; set; }

    public virtual DbSet<WhatsAppMessageData> WhatsAppMessageData { get; set; }

    public virtual DbSet<WhatsAppResult> WhatsAppResults { get; set; }

    public virtual DbSet<WhatsAppUrl> WhatsAppUrls { get; set; }

    public virtual DbSet<WorkPlanComment> WorkPlanComments { get; set; }

    public virtual DbSet<WorkPlanDetail> WorkPlanDetails { get; set; }

    public virtual DbSet<WorkPlanFooter> WorkPlanFooters { get; set; }

    public virtual DbSet<WorkPlanHeader> WorkPlanHeaders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=195.201.110.116;Database=LinkSoft;User ID=sa;Password=2221983@ahmed;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountFication>(entity =>
        {
            entity.HasKey(e => e.FicationId);

            entity.ToTable("AccountFication");

            entity.Property(e => e.AccountFicationNameL1).HasMaxLength(50);
            entity.Property(e => e.AccountFicationNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountFiscalYear>(entity =>
        {
            entity.HasKey(e => e.FiscalYearId);

            entity.ToTable("AccountFiscalYear");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FiscalYearNameL1).HasMaxLength(50);
            entity.Property(e => e.FiscalYearNameL2).HasMaxLength(50);
            entity.Property(e => e.IsClosed).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.AccountFiscalYears)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AccountFiscalYear_CompanyData");
        });

        modelBuilder.Entity<AccountFixedDetail>(entity =>
        {
            entity.HasKey(e => e.FixedId).HasName("PK_FixedDetail");

            entity.ToTable("AccountFixedDetail");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FixedNameL1).HasMaxLength(50);
            entity.Property(e => e.FixedNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Responsible).HasMaxLength(300);

            entity.HasOne(d => d.AccountFication).WithMany(p => p.AccountFixedDetails)
                .HasForeignKey(d => d.AccountFicationId)
                .HasConstraintName("FK_AccountFixedDetail_AccountFication");

            entity.HasOne(d => d.AccountName).WithMany(p => p.AccountFixedDetailAccountNames)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_AccountFixedDetail_AccountName");

            entity.HasOne(d => d.AccountNameLevel2).WithMany(p => p.AccountFixedDetailAccountNameLevel2s)
                .HasForeignKey(d => d.AccountNameLevel2Id)
                .HasConstraintName("FK_AccountFixedDetail_AccountName1");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.AccountFixedDetails)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AccountFixedDetail_CompanyData");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.AccountFixedDetails)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_AccountFixedDetail_CostCenter");
        });

        modelBuilder.Entity<AccountMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("AccountMenu");

            entity.Property(e => e.AccountMenuNameL1).HasMaxLength(50);
            entity.Property(e => e.AccountMenuNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountName>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK_AccountName_1");

            entity.ToTable("AccountName");

            entity.Property(e => e.AccountId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountNameL1).HasMaxLength(100);
            entity.Property(e => e.AccountNameL2).HasMaxLength(100);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NotMenu).HasDefaultValue(false);

            entity.HasOne(d => d.AccountFication).WithMany(p => p.AccountNames)
                .HasForeignKey(d => d.AccountFicationId)
                .HasConstraintName("FK_AccountName_AccountFication");

            entity.HasOne(d => d.AccountMenu).WithMany(p => p.AccountNames)
                .HasForeignKey(d => d.AccountMenuId)
                .HasConstraintName("FK_AccountName_AccountMenu");

            entity.HasOne(d => d.AccountNature).WithMany(p => p.AccountNames)
                .HasForeignKey(d => d.AccountNatureId)
                .HasConstraintName("FK_AccountName_AccountNature");

            entity.HasOne(d => d.AccountType).WithMany(p => p.AccountNames)
                .HasForeignKey(d => d.AccountTypeId)
                .HasConstraintName("FK_AccountName_AccountsType");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.AccountNames)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AccountName_CompanyData");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.AccountNames)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_AccountName_CurrencyData");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_AccountName_AccountName");
        });

        modelBuilder.Entity<AccountNature>(entity =>
        {
            entity.HasKey(e => e.NatureId);

            entity.ToTable("AccountNature");

            entity.Property(e => e.AccountNatureNameL1).HasMaxLength(10);
            entity.Property(e => e.AccountNatureNameL2).HasMaxLength(10);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("AccountType");

            entity.Property(e => e.AccountsTypeNameL1).HasMaxLength(50);
            entity.Property(e => e.AccountsTypeNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountsBalanceFooter>(entity =>
        {
            entity.HasKey(e => e.AccountsBalanceFooterId).HasName("PK_AccountsBalanceFooter_1");

            entity.ToTable("AccountsBalanceFooter");

            entity.Property(e => e.AccountsBalanceFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);

            entity.HasOne(d => d.AccountFication).WithMany(p => p.AccountsBalanceFooters)
                .HasForeignKey(d => d.AccountFicationId)
                .HasConstraintName("FK_AccountsBalanceFooter_AccountFication");

            entity.HasOne(d => d.AccountName).WithMany(p => p.AccountsBalanceFooters)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_AccountsBalanceFooter_AccountName");

            entity.HasOne(d => d.AccountsBalanceHeader).WithMany(p => p.AccountsBalanceFooters)
                .HasForeignKey(d => d.AccountsBalanceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AccountsBalanceFooter_AccountsBalanceHeader");
        });

        modelBuilder.Entity<AccountsBalanceHeader>(entity =>
        {
            entity.HasKey(e => e.AccountsBalanceHeaderId).HasName("PK_AccountsBalanceHeader_1");

            entity.ToTable("AccountsBalanceHeader");

            entity.Property(e => e.AccountsBalanceHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalBalance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalCredit).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDebit).HasDefaultValue(0.0);

            entity.HasOne(d => d.BalanceName).WithMany(p => p.AccountsBalanceHeaders)
                .HasForeignKey(d => d.BalanceNameId)
                .HasConstraintName("FK_AccountsBalanceHeader_BalanceName");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.AccountsBalanceHeaders)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AccountsBalanceHeader_CompanyData");
        });

        modelBuilder.Entity<ActivityCode>(entity =>
        {
            entity.ToTable("ActivityCode");

            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
        });

        modelBuilder.Entity<AdditionAdjustment>(entity =>
        {
            entity.HasKey(e => e.AdditionId);

            entity.ToTable("AdditionAdjustment");

            entity.Property(e => e.AdditionId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.AdditionAdjustments)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AdditionAdjustment_BranchesData");

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.AdditionAdjustments)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_AdditionAdjustment_ItemsHeader");

            entity.HasOne(d => d.StoreData).WithMany(p => p.AdditionAdjustments)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_AdditionAdjustment_StoreData");

            entity.HasOne(d => d.UnitType).WithMany(p => p.AdditionAdjustments)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_AdditionAdjustment_UnitType");
        });

        modelBuilder.Entity<ApiurltaxServer>(entity =>
        {
            entity.HasKey(e => e.ApiurltaxId);

            entity.ToTable("APIURLTaxServer");

            entity.Property(e => e.ApiurltaxId).HasColumnName("APIURLTaxId");
            entity.Property(e => e.Apiname)
                .HasMaxLength(30)
                .HasColumnName("APIName");
            entity.Property(e => e.Apiurltax)
                .HasMaxLength(100)
                .HasColumnName("APIURLTax");
            entity.Property(e => e.ApiurltaxPostmanId).HasColumnName("APIURLTaxPostmanId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<ApplicationMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK_Menu");

            entity.ToTable("ApplicationMenu");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.LevelCode).HasDefaultValue(1);
            entity.Property(e => e.MenuNameL1).HasMaxLength(50);
            entity.Property(e => e.MenuNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ParentCode).HasDefaultValue(0L);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.ApplicationMenus)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_ApplicationMenu_BranchesData");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ApplicationMenus)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ApplicationMenu_CompanyData");
        });

        modelBuilder.Entity<ApplicationMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("ApplicationMessage");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.MessageNameL1).HasMaxLength(500);
            entity.Property(e => e.MessageNameL2).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<ApplicationSetting>(entity =>
        {
            entity.HasKey(e => e.SettimgId);

            entity.ToTable("ApplicationSetting");

            entity.Property(e => e.SettimgId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountNumberActivate).HasDefaultValue(true);
            entity.Property(e => e.AccountNumberValue).HasMaxLength(50);
            entity.Property(e => e.BarCodeItems).HasDefaultValue(true);
            entity.Property(e => e.BarCodeStartValue).HasMaxLength(50);
            entity.Property(e => e.SettingNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ApplicationSettings)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ApplicationSetting_CompanyData");

            entity.HasOne(d => d.CountryCode).WithMany(p => p.ApplicationSettings)
                .HasForeignKey(d => d.CountryCodeId)
                .HasConstraintName("FK_ApplicationSetting_CountryCode");

            entity.HasOne(d => d.InventoryValuation).WithMany(p => p.ApplicationSettings)
                .HasForeignKey(d => d.InventoryValuationId)
                .HasConstraintName("FK_ApplicationSetting_InventoryValuation");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.Property(e => e.RoleId)
                .IsRequired()
                .HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.BankCode).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.BankCodeId)
                .HasConstraintName("FK_AspNetUsers_BankCode");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK_UserPermission");

            entity.ToTable("AspPermission");

            entity.Property(e => e.AddForm).HasDefaultValue(true);
            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeleteForm).HasDefaultValue(true);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.EditForm).HasDefaultValue(true);
            entity.Property(e => e.ExportDataGrid).HasDefaultValue(true);
            entity.Property(e => e.ExportFile).HasDefaultValue(true);
            entity.Property(e => e.FilterForm).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OpenForm).HasDefaultValue(true);
            entity.Property(e => e.PrinterReport).HasDefaultValue(true);
            entity.Property(e => e.ReadForm).HasDefaultValue(true);
            entity.Property(e => e.SearchForm).HasDefaultValue(true);

            entity.HasOne(d => d.ApplicationMenu).WithMany(p => p.AspPermissions)
                .HasForeignKey(d => d.ApplicationMenuId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ASPPermission_ApplicationMenu");

            entity.HasOne(d => d.AspNetUsers).WithMany(p => p.AspPermissions)
                .HasForeignKey(d => d.AspNetUsersId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AspPermission_AspNetUsers");
        });

        modelBuilder.Entity<AttachmentFile>(entity =>
        {
            entity.HasKey(e => e.AttachmentId);

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");

            entity.HasOne(d => d.AttachmentFilesType).WithMany(p => p.AttachmentFiles)
                .HasForeignKey(d => d.AttachmentFilesTypeId)
                .HasConstraintName("FK_AttachmentFiles_AttachmentFilesType");
        });

        modelBuilder.Entity<AttachmentFilesType>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PK_DocumentationType");

            entity.ToTable("AttachmentFilesType");

            entity.Property(e => e.AttachmentNameL1).HasMaxLength(50);
            entity.Property(e => e.AttachmentNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BalanceName>(entity =>
        {
            entity.HasKey(e => e.BalanceId);

            entity.ToTable("BalanceName");

            entity.Property(e => e.BalanceNameL1).HasMaxLength(50);
            entity.Property(e => e.BalanceNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<BankAtm>(entity =>
        {
            entity.HasKey(e => e.Atmid);

            entity.ToTable("BankATM");

            entity.Property(e => e.Atmid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ATMId");
            entity.Property(e => e.Atmaddress).HasColumnName("ATMAddress");
            entity.Property(e => e.Atmcode)
                .HasMaxLength(50)
                .HasColumnName("ATMCode");
            entity.Property(e => e.AtmcounterForMonth).HasColumnName("ATMCounterForMonth");
            entity.Property(e => e.Atmlat)
                .HasMaxLength(50)
                .HasColumnName("ATMLat");
            entity.Property(e => e.Atmlocation).HasColumnName("ATMLocation");
            entity.Property(e => e.Atmlong)
                .HasMaxLength(50)
                .HasColumnName("ATMLong");
            entity.Property(e => e.Atmmodel)
                .HasMaxLength(50)
                .HasColumnName("ATMModel");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BankCode).WithMany(p => p.BankAtms)
                .HasForeignKey(d => d.BankCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BankATM_BankCode");

            entity.HasOne(d => d.CityCode).WithMany(p => p.BankAtms)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_BankATM_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.BankAtms)
                .HasForeignKey(d => d.CompanyDataId)
                .HasConstraintName("FK_BankATM_CompanyData");

            entity.HasOne(d => d.GovernorateCode).WithMany(p => p.BankAtms)
                .HasForeignKey(d => d.GovernorateCodeId)
                .HasConstraintName("FK_BankATM_GovernorateCode");
        });

        modelBuilder.Entity<BankCode>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK_BankName");

            entity.ToTable("BankCode");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankEmail).HasMaxLength(50);
            entity.Property(e => e.BankMobil).HasMaxLength(40);
            entity.Property(e => e.BankPhone).HasMaxLength(10);
            entity.Property(e => e.BanknameL1).HasMaxLength(50);
            entity.Property(e => e.BanknameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CityCode).WithMany(p => p.BankCodes)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_BankCode_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.BankCodes)
                .HasForeignKey(d => d.CompanyDataId)
                .HasConstraintName("FK_BankCode_CompanyData");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.BankCodes)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_BankCode_CurrencyData");

            entity.HasOne(d => d.GovernorateCode).WithMany(p => p.BankCodes)
                .HasForeignKey(d => d.GovernorateCodeId)
                .HasConstraintName("FK_BankCode_GovernorateCode");
        });

        modelBuilder.Entity<BankContract>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK_BankContract_1");

            entity.ToTable("BankContract");

            entity.Property(e => e.ContractId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Atmnumber).HasColumnName("ATMNumber");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BankCode).WithMany(p => p.BankContracts)
                .HasForeignKey(d => d.BankCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BankContract_BankCode");
        });

        modelBuilder.Entity<BranchList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BranchList");

            entity.Property(e => e.AspNetUserId).HasMaxLength(450);
            entity.Property(e => e.BranchAddress).HasMaxLength(100);
            entity.Property(e => e.BranchEmail).HasMaxLength(50);
            entity.Property(e => e.BranchMobil).HasMaxLength(40);
            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.BranchPhone).HasMaxLength(11);
            entity.Property(e => e.BranchWhatsapp).HasMaxLength(11);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<BranchesData>(entity =>
        {
            entity.HasKey(e => e.BranchId);

            entity.Property(e => e.BranchId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AdditionalInformation).HasMaxLength(100);
            entity.Property(e => e.BranchAddress).HasMaxLength(100);
            entity.Property(e => e.BranchEmail).HasMaxLength(50);
            entity.Property(e => e.BranchMobil).HasMaxLength(40);
            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.BranchPhone).HasMaxLength(11);
            entity.Property(e => e.BranchWhatsapp).HasMaxLength(11);
            entity.Property(e => e.BranchesDataId).ValueGeneratedOnAdd();
            entity.Property(e => e.BuildingNumber).HasMaxLength(5);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FloorNumber).HasMaxLength(5);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.Landmark).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(7);
            entity.Property(e => e.RoomNumber).HasMaxLength(3);

            entity.HasOne(d => d.BranchManagerNavigation).WithMany(p => p.BranchesData)
                .HasForeignKey(d => d.BranchManager)
                .HasConstraintName("FK_BranchesData_EmployeeData");

            entity.HasOne(d => d.CityCode).WithMany(p => p.BranchesData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_BranchesData_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.BranchesData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BranchesData_CompanyData");
        });

        modelBuilder.Entity<BranchesList>(entity =>
        {
            entity.HasKey(e => e.BranchListId);

            entity.ToTable("BranchesList");

            entity.Property(e => e.BranchListId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AspNetUserId).HasMaxLength(450);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.BranchesLists)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BranchesList_BranchesData");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.BranchesLists)
                .HasForeignKey(d => d.CompanyDataId)
                .HasConstraintName("FK_BranchesList_CompanyData");
        });

        modelBuilder.Entity<BranchesSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BranchesSales");

            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.PriceNameL1).HasMaxLength(50);
            entity.Property(e => e.TaxNameL1).HasMaxLength(50);
            entity.Property(e => e.UnitNameL1).HasMaxLength(70);
        });

        modelBuilder.Entity<CheckDetail>(entity =>
        {
            entity.HasKey(e => e.CheckId).HasName("PK_CheckHeader");

            entity.Property(e => e.CheckId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CheckName).HasMaxLength(50);
            entity.Property(e => e.CheckSiteName).HasMaxLength(50);
            entity.Property(e => e.CheckValue).HasDefaultValue(0.0);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.RepetitionTimes).HasMaxLength(50);
            entity.Property(e => e.UnderlineCheck).HasMaxLength(50);

            entity.HasOne(d => d.AccountNameFromNavigation).WithMany(p => p.CheckDetailAccountNameFromNavigations)
                .HasForeignKey(d => d.AccountNameFrom)
                .HasConstraintName("FK_CheckDetails_AccountName");

            entity.HasOne(d => d.AccountNameToNavigation).WithMany(p => p.CheckDetailAccountNameToNavigations)
                .HasForeignKey(d => d.AccountNameTo)
                .HasConstraintName("FK_CheckDetails_AccountName1");

            entity.HasOne(d => d.BankName).WithMany(p => p.CheckDetails)
                .HasForeignKey(d => d.BankNameId)
                .HasConstraintName("FK_CheckHeader_BankCode");

            entity.HasOne(d => d.CheckStatus).WithMany(p => p.CheckDetails)
                .HasForeignKey(d => d.CheckStatusId)
                .HasConstraintName("FK_CheckHeader_CheckStatus");

            entity.HasOne(d => d.CheckType).WithMany(p => p.CheckDetails)
                .HasForeignKey(d => d.CheckTypeId)
                .HasConstraintName("FK_CheckHeader_CheckType");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.CheckDetails)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CheckHeader_CompanyData");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.CheckDetails)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_CheckDetails_CostCenter");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.CheckDetails)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_CheckDetails_CurrencyData");
        });

        modelBuilder.Entity<CheckStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("CheckStatus");

            entity.Property(e => e.CheckStatusNameL1)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CheckStatusNameL2)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<CheckType>(entity =>
        {
            entity.ToTable("CheckType");

            entity.Property(e => e.ChecknameL1).HasMaxLength(50);
            entity.Property(e => e.ChecknameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<CityCode>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK_CityCode_1");

            entity.ToTable("CityCode");

            entity.Property(e => e.CityNameL1).HasMaxLength(75);
            entity.Property(e => e.CityNameL2).HasMaxLength(75);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Posted).HasDefaultValue(false);

            entity.HasOne(d => d.GovernorateCode).WithMany(p => p.CityCodes)
                .HasForeignKey(d => d.GovernorateCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CityCode_GovernorateCode");
        });

        modelBuilder.Entity<ClientAccessToken>(entity =>
        {
            entity.HasKey(e => e.AccessTokenId).HasName("PK_ClientAccessToken_1");

            entity.ToTable("ClientAccessToken");

            entity.Property(e => e.CreateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateTime)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Scope).HasMaxLength(20);
            entity.Property(e => e.TokenType).HasMaxLength(20);

            entity.HasOne(d => d.ClientDataToken).WithMany(p => p.ClientAccessTokens)
                .HasForeignKey(d => d.ClientDataTokenId)
                .HasConstraintName("FK_ClientAccessToken_ClientDataToken");
        });

        modelBuilder.Entity<ClientDataToken>(entity =>
        {
            entity.HasKey(e => e.ClientDataTokenId).HasName("PK_AccessTokenBefore");

            entity.ToTable("ClientDataToken");

            entity.Property(e => e.ClientDataTokenId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ClientId).HasMaxLength(100);
            entity.Property(e => e.ClientSecret1).HasMaxLength(100);
            entity.Property(e => e.ClientSecret2).HasMaxLength(100);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.ClientDataTokens)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClientDataToken_BranchesData");
        });

        modelBuilder.Entity<ColorType>(entity =>
        {
            entity.HasKey(e => e.ColorId).HasName("PK_ItemsColor_1");

            entity.ToTable("ColorType");

            entity.Property(e => e.ColorNameL1).HasMaxLength(50);
            entity.Property(e => e.ColorNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<CompanyData>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AdditionalInformation).HasMaxLength(100);
            entity.Property(e => e.BuildingNumber).HasMaxLength(5);
            entity.Property(e => e.CommercialRegisterNumber).HasMaxLength(10);
            entity.Property(e => e.CompanyAddress).HasMaxLength(100);
            entity.Property(e => e.CompanyDataId).ValueGeneratedOnAdd();
            entity.Property(e => e.CompanyEmail).HasMaxLength(50);
            entity.Property(e => e.CompanyMobil).HasMaxLength(40);
            entity.Property(e => e.CompanyPhone).HasMaxLength(10);
            entity.Property(e => e.CompanyWhatsapp).HasMaxLength(11);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FloorNumber).HasMaxLength(5);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.LandMark).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(7);
            entity.Property(e => e.RoomNumber).HasMaxLength(3);
            entity.Property(e => e.TaxRegistrationNumber).HasMaxLength(10);
            entity.Property(e => e.TaxesErrand).HasMaxLength(50);

            entity.HasOne(d => d.ActivityCode).WithMany(p => p.CompanyData)
                .HasForeignKey(d => d.ActivityCodeId)
                .HasConstraintName("FK_CompanyData_ActivityCode");

            entity.HasOne(d => d.CityCode).WithMany(p => p.CompanyData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_CompanyData_CityCode");
        });

        modelBuilder.Entity<ConContractorDatum>(entity =>
        {
            entity.HasKey(e => e.ContractorId).HasName("PK_ContractorData");

            entity.ToTable("Con_ContractorData");

            entity.Property(e => e.ContractorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AdditionalInformation).HasMaxLength(100);
            entity.Property(e => e.BuildingNumber).HasMaxLength(5);
            entity.Property(e => e.CommercialRegisterNumber).HasMaxLength(10);
            entity.Property(e => e.ContractorAddress).HasMaxLength(100);
            entity.Property(e => e.ContractorBarCode).HasMaxLength(50);
            entity.Property(e => e.ContractorEmail).HasMaxLength(50);
            entity.Property(e => e.ContractorFax).HasMaxLength(10);
            entity.Property(e => e.ContractorMobil).HasMaxLength(40);
            entity.Property(e => e.ContractorName).HasMaxLength(75);
            entity.Property(e => e.ContractorPhone).HasMaxLength(10);
            entity.Property(e => e.ContractorWhatsapp).HasMaxLength(11);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FloorNumber).HasMaxLength(5);
            entity.Property(e => e.IsCompany).HasDefaultValue(false);
            entity.Property(e => e.IsCustomer).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsNotActiveTax).HasDefaultValue(false);
            entity.Property(e => e.LandMark).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(14);
            entity.Property(e => e.PostalCode).HasMaxLength(7);
            entity.Property(e => e.RoomNumber).HasMaxLength(3);
            entity.Property(e => e.TaxRegistrationNumber).HasMaxLength(10);
            entity.Property(e => e.TaxesErrand).HasMaxLength(50);

            entity.HasOne(d => d.AccountsName).WithMany(p => p.ConContractorData)
                .HasForeignKey(d => d.AccountsNameId)
                .HasConstraintName("FK_ContractorData_AccountName");

            entity.HasOne(d => d.CityCode).WithMany(p => p.ConContractorData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_ContractorData_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ConContractorData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ContractorData_CompanyData");

            entity.HasOne(d => d.ContractorGroups).WithMany(p => p.ConContractorData)
                .HasForeignKey(d => d.ContractorGroupsId)
                .HasConstraintName("FK_ContractorData_SupplierGroups");

            entity.HasOne(d => d.ContractorManagerNavigation).WithMany(p => p.ConContractorData)
                .HasForeignKey(d => d.ContractorManager)
                .HasConstraintName("FK_ContractorData_EmployeesData");
        });

        modelBuilder.Entity<ConContractorExtractDetail>(entity =>
        {
            entity.HasKey(e => e.ContractorDetailsId).HasName("PK_Con_ContractorDetails");

            entity.ToTable("Con_ContractorExtractDetails");

            entity.Property(e => e.ContractorDetailsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ImplementationRate).HasDefaultValue(0.0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.ContractorMaster).WithMany(p => p.ConContractorExtractDetails)
                .HasForeignKey(d => d.ContractorMasterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Con_ContractorExtractDetails_Con_ContractorExtractMaster");

            entity.HasOne(d => d.ProjectItems).WithMany(p => p.ConContractorExtractDetails)
                .HasForeignKey(d => d.ProjectItemsId)
                .HasConstraintName("FK_Con_ContractorExtractDetails_Con_ProjectItems");

            entity.HasOne(d => d.UnitType).WithMany(p => p.ConContractorExtractDetails)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_Con_ContractorExtractDetails_UnitType");
        });

        modelBuilder.Entity<ConContractorExtractMaster>(entity =>
        {
            entity.HasKey(e => e.ContractorId).HasName("PK_ContractorExtract");

            entity.ToTable("Con_ContractorExtractMaster");

            entity.Property(e => e.ContractorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetTotal).HasDefaultValue(0.0);
            entity.Property(e => e.Payments).HasDefaultValue(0.0);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.TotalDiscount).HasDefaultValue(0.0);
            entity.Property(e => e.TotalTax).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValu).HasDefaultValue(0.0);

            entity.HasOne(d => d.CompanyDate).WithMany(p => p.ConContractorExtractMasters)
                .HasForeignKey(d => d.CompanyDateId)
                .HasConstraintName("FK_ContractorExtract_CompanyData");

            entity.HasOne(d => d.ContractorData).WithMany(p => p.ConContractorExtractMasters)
                .HasForeignKey(d => d.ContractorDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ContractorExtract_Con_ContractorData");

            entity.HasOne(d => d.ProjectData).WithMany(p => p.ConContractorExtractMasters)
                .HasForeignKey(d => d.ProjectDataId)
                .HasConstraintName("FK_ContractorExtract_Con_ProjectsData");
        });

        modelBuilder.Entity<ConProjectItem>(entity =>
        {
            entity.HasKey(e => e.ItemsId);

            entity.ToTable("Con_ProjectItems");

            entity.Property(e => e.ItemsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ConProjectItems)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Con_ProjectItems_CompanyData");
        });

        modelBuilder.Entity<ConProjectsData>(entity =>
        {
            entity.HasKey(e => e.ProjectId);

            entity.ToTable("Con_ProjectsData");

            entity.Property(e => e.ProjectId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ProjectNameL1).HasMaxLength(50);
            entity.Property(e => e.ProjectNameL2).HasMaxLength(50);
            entity.Property(e => e.ProjectPeriod).HasMaxLength(10);

            entity.HasOne(d => d.AccountsName).WithMany(p => p.ConProjectsData)
                .HasForeignKey(d => d.AccountsNameId)
                .HasConstraintName("FK_Con_ProjectsData_AccountName");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ConProjectsData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Con_ProjectsData_CompanyData");
        });

        modelBuilder.Entity<CostCenter>(entity =>
        {
            entity.HasKey(e => e.CenterId).HasName("PK_CostElement");

            entity.ToTable("CostCenter");

            entity.Property(e => e.CenterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CenterName).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NotMenu).HasDefaultValue(false);

            entity.HasOne(d => d.AccountMenu).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.AccountMenuId)
                .HasConstraintName("FK_CostCenter_AccountMenu");

            entity.HasOne(d => d.AccountNature).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.AccountNatureId)
                .HasConstraintName("FK_CostCenter_AccountNature");

            entity.HasOne(d => d.AccountType).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.AccountTypeId)
                .HasConstraintName("FK_CostElement_AccountType");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CostElement_BranchesData");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_CostCenter_CostCenter1");
        });

        modelBuilder.Entity<CostGeneralAccountFooter>(entity =>
        {
            entity.HasKey(e => e.JournalFooterId).HasName("PK_CostGeneralAccountFooter_1");

            entity.ToTable("CostGeneralAccountFooter");

            entity.Property(e => e.JournalFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AccountName).WithMany(p => p.CostGeneralAccountFooters)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_CostGeneralAccountFooter_CostCenter");

            entity.HasOne(d => d.JournalHeader).WithMany(p => p.CostGeneralAccountFooters)
                .HasForeignKey(d => d.JournalHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CostGeneralAccountFooter_CostGeneralAccountHeader");
        });

        modelBuilder.Entity<CostGeneralAccountHeader>(entity =>
        {
            entity.HasKey(e => e.JournalHeaderId).HasName("PK_CostGeneralAccountHeader_1");

            entity.ToTable("CostGeneralAccountHeader");

            entity.Property(e => e.JournalHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Totalbalance).HasDefaultValue(0.0);
            entity.Property(e => e.Totalcredit).HasDefaultValue(0.0);
            entity.Property(e => e.Totaldebit).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.CostGeneralAccountHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CostGeneralAccountHeader_BranchesData");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.CostGeneralAccountHeaders)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_CostGeneralAccountHeader_CurrencyData");
        });

        modelBuilder.Entity<CostJournalFooter>(entity =>
        {
            entity.HasKey(e => e.JournalFooterId).HasName("PK_CostJournalFooter_1");

            entity.ToTable("CostJournalFooter");

            entity.Property(e => e.JournalFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AccountName).WithMany(p => p.CostJournalFooters)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_CostJournalFooter_CostCenter");

            entity.HasOne(d => d.JournalHeader).WithMany(p => p.CostJournalFooters)
                .HasForeignKey(d => d.JournalHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CostJournalFooter_CostJournalHeader");
        });

        modelBuilder.Entity<CostJournalHeader>(entity =>
        {
            entity.HasKey(e => e.JournalHeaderId).HasName("PK_CostJournalHeader_1");

            entity.ToTable("CostJournalHeader");

            entity.Property(e => e.JournalHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Totalbalance).HasDefaultValue(0.0);
            entity.Property(e => e.Totalcredit).HasDefaultValue(0.0);
            entity.Property(e => e.Totaldebit).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.CostJournalHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CostJournalHeader_BranchesData");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.CostJournalHeaders)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_CostJournalHeader_CurrencyData");
        });

        modelBuilder.Entity<CountryCode>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("CountryCode");

            entity.Property(e => e.CodeTaxTabel).HasMaxLength(5);
            entity.Property(e => e.CountryNameL1).HasMaxLength(75);
            entity.Property(e => e.CountryNameL2).HasMaxLength(75);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Posted).HasDefaultValue(false);
        });

        modelBuilder.Entity<CrmContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CRM_Contacts_1");

            entity.ToTable("CRM_Contacts");

            entity.Property(e => e.Company).HasMaxLength(256);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(256);
            entity.Property(e => e.LastName).HasMaxLength(256);
            entity.Property(e => e.Phone).HasMaxLength(256);
        });

        modelBuilder.Entity<CrmOpportunity>(entity =>
        {
            entity.ToTable("CRM_Opportunities");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CloseDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(450);

            entity.HasOne(d => d.Contact).WithMany(p => p.CrmOpportunities)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRM_Opportunities_CRM_Contacts");

            entity.HasOne(d => d.Status).WithMany(p => p.CrmOpportunities)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRM_Opportunities_CRM_OpportunityStatuses");
        });

        modelBuilder.Entity<CrmOpportunityStatus>(entity =>
        {
            entity.ToTable("CRM_OpportunityStatuses");
        });

        modelBuilder.Entity<CrmTask>(entity =>
        {
            entity.ToTable("CRM_Tasks");

            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(256);

            entity.HasOne(d => d.Opportunity).WithMany(p => p.CrmTasks)
                .HasForeignKey(d => d.OpportunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRM_Tasks_CRM_Opportunities");

            entity.HasOne(d => d.Status).WithMany(p => p.CrmTasks)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_CRM_Tasks_CRM_Taskstatuses");

            entity.HasOne(d => d.Type).WithMany(p => p.CrmTasks)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRM_Tasks_CRM_TaskTypes");
        });

        modelBuilder.Entity<CrmTaskType>(entity =>
        {
            entity.ToTable("CRM_TaskTypes");
        });

        modelBuilder.Entity<CrmTaskstatus>(entity =>
        {
            entity.ToTable("CRM_Taskstatuses");

            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<CurrencyDatum>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK_Currency_1");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.CurrencyNameL1).HasMaxLength(50);
            entity.Property(e => e.CurrencyNameL2).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<CurrencySetting>(entity =>
        {
            entity.ToTable("CurrencySetting");

            entity.Property(e => e.CurrencySettingId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DefaultCurrency).HasDefaultValue(false);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.CurrencySettings)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CurrencySetting_CompanyData");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.CurrencySettings)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_CurrencySetting_CurrencyData");
        });

        modelBuilder.Entity<CustomerCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.CategoryNameL1).HasMaxLength(50);
            entity.Property(e => e.CategoryNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerDatum>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.Property(e => e.CustomerId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AdditionalInformation).HasMaxLength(100);
            entity.Property(e => e.BuildingNumber).HasMaxLength(5);
            entity.Property(e => e.CommercialRegisterNumber).HasMaxLength(10);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.CustomerAddress).HasMaxLength(100);
            entity.Property(e => e.CustomerBarCode).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CustomerEmail).HasMaxLength(50);
            entity.Property(e => e.CustomerFax).HasMaxLength(10);
            entity.Property(e => e.CustomerMobil).HasMaxLength(40);
            entity.Property(e => e.CustomerPhone).HasMaxLength(10);
            entity.Property(e => e.CustomerWhatsapp).HasMaxLength(11);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FloorNumber).HasMaxLength(5);
            entity.Property(e => e.IsCompany).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsNotActiveTax).HasDefaultValue(false);
            entity.Property(e => e.IsSupplier).HasDefaultValue(false);
            entity.Property(e => e.LandMark).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(14);
            entity.Property(e => e.PostalCode).HasMaxLength(7);
            entity.Property(e => e.RoomNumber).HasMaxLength(3);
            entity.Property(e => e.TaxRegistrationNumber).HasMaxLength(10);
            entity.Property(e => e.TaxesErrand).HasMaxLength(50);

            entity.HasOne(d => d.AccountsNameSales).WithMany(p => p.CustomerData)
                .HasForeignKey(d => d.AccountsNameSalesId)
                .HasConstraintName("FK_CustomerData_AccountName");

            entity.HasOne(d => d.CityCode).WithMany(p => p.CustomerData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_CustomerData_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.CustomerData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CustomerData_CompanyData");

            entity.HasOne(d => d.CustomerCategories).WithMany(p => p.CustomerData)
                .HasForeignKey(d => d.CustomerCategoriesId)
                .HasConstraintName("FK_CustomerData_CustomerCategories");

            entity.HasOne(d => d.CustomerModes).WithMany(p => p.CustomerData)
                .HasForeignKey(d => d.CustomerModesId)
                .HasConstraintName("FK_CustomerData_CustomerModes");

            entity.HasOne(d => d.RepresentativeData).WithMany(p => p.CustomerData)
                .HasForeignKey(d => d.RepresentativeDataId)
                .HasConstraintName("FK_CustomerData_RepresentativeData");
        });

        modelBuilder.Entity<CustomerMode>(entity =>
        {
            entity.HasKey(e => e.DocumentsId).HasName("PK_DocumentsType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DocumentNameL1).HasMaxLength(30);
            entity.Property(e => e.DocumentNameL2).HasMaxLength(30);
            entity.Property(e => e.DocumentType).HasMaxLength(1);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DatabaseDescription>(entity =>
        {
            entity.ToTable("DatabaseDescription");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NameL1).HasMaxLength(50);
            entity.Property(e => e.NameL2).HasMaxLength(50);
            entity.Property(e => e.ShortName).HasMaxLength(10);

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_DatabaseDescription_DatabaseDescription");
        });

        modelBuilder.Entity<DelegateDatum>(entity =>
        {
            entity.HasKey(e => e.DelegateId).HasName("PK_RepresentativeData");

            entity.Property(e => e.DelegateId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.BranchesDataId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DelegateAddress).HasMaxLength(100);
            entity.Property(e => e.DelegateBarCode).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DelegateEmail).HasMaxLength(50);
            entity.Property(e => e.DelegateMobil).HasMaxLength(50);
            entity.Property(e => e.DelegateNameL1).HasMaxLength(50);
            entity.Property(e => e.DelegateNameL2).HasMaxLength(50);
            entity.Property(e => e.DelegateNationalId)
                .HasMaxLength(14)
                .HasColumnName("DelegateNationalID");
            entity.Property(e => e.DelegatePhone).HasMaxLength(50);
            entity.Property(e => e.DelegateWhatsapp).HasMaxLength(11);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");

            entity.HasOne(d => d.AccountsName).WithMany(p => p.DelegateData)
                .HasForeignKey(d => d.AccountsNameId)
                .HasConstraintName("FK_RepresentativeData_AccountName");

            entity.HasOne(d => d.CityCode).WithMany(p => p.DelegateData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_RepresentativeData_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.DelegateData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RepresentativeData_CompanyData");
        });

        modelBuilder.Entity<DeliveryMode>(entity =>
        {
            entity.HasKey(e => e.DeliveryId);

            entity.Property(e => e.CodeTax).HasMaxLength(5);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DeliveryNameL1).HasMaxLength(50);
            entity.Property(e => e.DeliveryNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentsId);

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<DeviceCode>(entity =>
        {
            entity.HasKey(e => e.UserCode);

            entity.Property(e => e.UserCode).HasMaxLength(200);
            entity.Property(e => e.ClientId)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Data).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DeviceCode1)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("DeviceCode");
            entity.Property(e => e.SessionId).HasMaxLength(100);
            entity.Property(e => e.SubjectId).HasMaxLength(200);
        });

        modelBuilder.Entity<DiscountType>(entity =>
        {
            entity.HasKey(e => e.DiscountId).HasName("PK_ItemsDiscount");

            entity.ToTable("DiscountType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DiscountNameL1).HasMaxLength(50);
            entity.Property(e => e.DiscountNameL2).HasMaxLength(50);
            entity.Property(e => e.DiscountPercent).HasDefaultValue(0.0);
            entity.Property(e => e.DiscountValue).HasDefaultValue(0.0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<DocumentsMode>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK_Documents");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DocumentType).HasMaxLength(2);
            entity.Property(e => e.DocumentTypeName).HasMaxLength(50);
            entity.Property(e => e.DocumentTypeVersion).HasMaxLength(3);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EduAcademyCourse>(entity =>
        {
            entity.HasKey(e => e.CourseId);

            entity.ToTable("Edu_AcademyCourse");

            entity.Property(e => e.CourseId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CourseName).HasMaxLength(50);
            entity.Property(e => e.CourseValue).HasDefaultValue(0.0);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.EduAcademyCourses)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Edu_AcademyCourse_BranchesData");

            entity.HasOne(d => d.ParentCourseNavigation).WithMany(p => p.InverseParentCourseNavigation)
                .HasForeignKey(d => d.ParentCourse)
                .HasConstraintName("FK_Edu_AcademyCourse_Edu_AcademyCourse");
        });

        modelBuilder.Entity<EduQuestionDetail>(entity =>
        {
            entity.HasKey(e => e.QuestionDetailsId).HasName("PK_Edu_QuestionDetalis");

            entity.ToTable("Edu_QuestionDetails");

            entity.Property(e => e.QuestionDetailsId).ValueGeneratedNever();
            entity.Property(e => e.AnswerCheck).HasDefaultValue(false);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.QuestionsAnswer).HasMaxLength(50);

            entity.HasOne(d => d.QuestionsMaster).WithMany(p => p.EduQuestionDetails)
                .HasForeignKey(d => d.QuestionsMasterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Edu_QuestionDetails_Edu_QuestionsMaster");
        });

        modelBuilder.Entity<EduQuestionType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("Edu_QuestionType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<EduQuestionsMaster>(entity =>
        {
            entity.HasKey(e => e.QuestionMasterId).HasName("PK_Edu_Questions");

            entity.ToTable("Edu_QuestionsMaster");

            entity.Property(e => e.QuestionMasterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.QuestionAnswer).HasMaxLength(10);

            entity.HasOne(d => d.AcademyCourse).WithMany(p => p.EduQuestionsMasters)
                .HasForeignKey(d => d.AcademyCourseId)
                .HasConstraintName("FK_Edu_Questions_Edu_AcademyCourse");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.EduQuestionsMasters)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Edu_Questions_BranchesData");

            entity.HasOne(d => d.QuestionType).WithMany(p => p.EduQuestionsMasters)
                .HasForeignKey(d => d.QuestionTypeId)
                .HasConstraintName("FK_Edu_Questions_Edu_QuestionType");
        });

        modelBuilder.Entity<EduStudentCourse>(entity =>
        {
            entity.HasKey(e => e.StudentCourseId);

            entity.ToTable("Edu_StudentCourse");

            entity.Property(e => e.StudentCourseId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.StudentData).WithMany(p => p.EduStudentCourses)
                .HasForeignKey(d => d.StudentDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Edu_StudentCourse_Edu_StudentData");
        });

        modelBuilder.Entity<EduStudentDatum>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("Edu_StudentData");

            entity.Property(e => e.StudentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DateFinsh).HasMaxLength(10);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.EducationeStimateId).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(14);
            entity.Property(e => e.PassportNumber).HasMaxLength(15);
            entity.Property(e => e.StudentAddress).HasMaxLength(100);
            entity.Property(e => e.StudentBarCode).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StudentEmail).HasMaxLength(50);
            entity.Property(e => e.StudentMobil).HasMaxLength(36);
            entity.Property(e => e.StudentNameL1).HasMaxLength(150);
            entity.Property(e => e.StudentNameL2).HasMaxLength(150);
            entity.Property(e => e.StudentPhone).HasMaxLength(15);
            entity.Property(e => e.StudentWhatsapp).HasMaxLength(12);
            entity.Property(e => e.YareEducation).HasMaxLength(4);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Edu_StudentData_BranchesData");

            entity.HasOne(d => d.CityCode).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_Edu_StudentData_CityCode");

            entity.HasOne(d => d.EducationData).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.EducationDataId)
                .HasConstraintName("FK_Edu_StudentData_EducationData");

            entity.HasOne(d => d.EducationeStimate).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.EducationeStimateId)
                .HasConstraintName("FK_Edu_StudentData_EducationeStimate");

            entity.HasOne(d => d.GenderData).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.GenderDataId)
                .HasConstraintName("FK_Edu_StudentData_GenderData");

            entity.HasOne(d => d.RecruitmentData).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.RecruitmentDataId)
                .HasConstraintName("FK_Edu_StudentData_RecruitmentData");

            entity.HasOne(d => d.SocialData).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.SocialDataId)
                .HasConstraintName("FK_Edu_StudentData_SocialData");

            entity.HasOne(d => d.UniversityData).WithMany(p => p.EduStudentData)
                .HasForeignKey(d => d.UniversityDataId)
                .HasConstraintName("FK_Edu_StudentData_UniversityData");
        });

        modelBuilder.Entity<EduStudentPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_Edu_StudentsPayment");

            entity.ToTable("Edu_StudentPayment");

            entity.Property(e => e.PaymentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AcademyCourse).WithMany(p => p.EduStudentPayments)
                .HasForeignKey(d => d.AcademyCourseId)
                .HasConstraintName("FK_Edu_StudentsPayment_Edu_AcademyCourse");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.EduStudentPayments)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_Edu_StudentPayment_BranchesData");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.EduStudentPayments)
                .HasForeignKey(d => d.CompanyDataId)
                .HasConstraintName("FK_Edu_StudentPayment_CompanyData");

            entity.HasOne(d => d.StudentData).WithMany(p => p.EduStudentPayments)
                .HasForeignKey(d => d.StudentDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Edu_StudentsPayment_Edu_StudentData");
        });

        modelBuilder.Entity<EduStudentQuestion>(entity =>
        {
            entity.HasKey(e => e.StudentQuestionId);

            entity.ToTable("Edu_StudentQuestion");

            entity.Property(e => e.StudentQuestionId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.StudentAnswer).HasMaxLength(10);
        });

        modelBuilder.Entity<EducationDatum>(entity =>
        {
            entity.HasKey(e => e.EducationId).HasName("PK_EducationName");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationeStimate>(entity =>
        {
            entity.HasKey(e => e.EducationestimateId).HasName("PK_Educationestimate");

            entity.ToTable("EducationeStimate");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.StimateNameL1).HasMaxLength(15);
            entity.Property(e => e.StimateNameL2).HasMaxLength(20);
        });

        modelBuilder.Entity<EmpAccept>(entity =>
        {
            entity.HasKey(e => e.AcceptId);

            entity.ToTable("EmpAccept");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.EmpAcceptType).WithMany(p => p.EmpAccepts)
                .HasForeignKey(d => d.EmpAcceptTypeId)
                .HasConstraintName("FK_EmpAccept_EmpAcceptType");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.EmpAccepts)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmpAccept_EmployeesData");
        });

        modelBuilder.Entity<EmpAcceptType>(entity =>
        {
            entity.HasKey(e => e.AcceptId);

            entity.ToTable("EmpAcceptType");

            entity.Property(e => e.AcceptNameL1).HasMaxLength(20);
            entity.Property(e => e.AcceptNameL2).HasMaxLength(30);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpAttend>(entity =>
        {
            entity.HasKey(e => e.AttendId);

            entity.ToTable("EmpAttend");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OnTime).HasPrecision(0);
            entity.Property(e => e.OnTimes).HasPrecision(0);
            entity.Property(e => e.OutTime).HasPrecision(0);
            entity.Property(e => e.OutTimes).HasPrecision(0);
            entity.Property(e => e.OverTime).HasPrecision(0);
            entity.Property(e => e.TotalTime).HasPrecision(0);

            entity.HasOne(d => d.AttendType).WithMany(p => p.EmpAttends)
                .HasForeignKey(d => d.AttendTypeId)
                .HasConstraintName("FK_EmpAttend_EmpAttendType");

            entity.HasOne(d => d.EmpDayWeek).WithMany(p => p.EmpAttends)
                .HasForeignKey(d => d.EmpDayWeekId)
                .HasConstraintName("FK_EmpAttend_EmpDayWeek");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.EmpAttends)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmpAttend_EmployeesData");
        });

        modelBuilder.Entity<EmpAttendType>(entity =>
        {
            entity.HasKey(e => e.AttendId);

            entity.ToTable("EmpAttendType");

            entity.Property(e => e.AttendNameL1).HasMaxLength(10);
            entity.Property(e => e.AttendNameL2).HasMaxLength(10);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpContractDetali>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK_EmpContractF");

            entity.Property(e => e.ContractId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.EmpContractHid).HasColumnName("EmpContractHId");
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ValueElment).HasDefaultValue(0.0);

            entity.HasOne(d => d.EmpContractH).WithMany(p => p.EmpContractDetalis)
                .HasForeignKey(d => d.EmpContractHid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmpContractF_EmpContractH");

            entity.HasOne(d => d.EmpElementData).WithMany(p => p.EmpContractDetalis)
                .HasForeignKey(d => d.EmpElementDataId)
                .HasConstraintName("FK_EmpContractF_EmpElementData");

            entity.HasOne(d => d.EmpElementType).WithMany(p => p.EmpContractDetalis)
                .HasForeignKey(d => d.EmpElementTypeId)
                .HasConstraintName("FK_EmpContractF_EmpElementType");
        });

        modelBuilder.Entity<EmpContractMaster>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK_EmpContractH");

            entity.ToTable("EmpContractMaster");

            entity.Property(e => e.ContractId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.EmpContractType).WithMany(p => p.EmpContractMasters)
                .HasForeignKey(d => d.EmpContractTypeId)
                .HasConstraintName("FK_EmpContractH_EmpContractType");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.EmpContractMasters)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmpContractH_EmployeesData");
        });

        modelBuilder.Entity<EmpContractType>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK_ContractType");

            entity.ToTable("EmpContractType");

            entity.Property(e => e.ContractNameL1).HasMaxLength(50);
            entity.Property(e => e.ContractNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpDayWeek>(entity =>
        {
            entity.HasKey(e => e.DayId).HasName("PK_DayWeekle");

            entity.ToTable("EmpDayWeek");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DayNameL1).HasMaxLength(10);
            entity.Property(e => e.DayNameL2).HasMaxLength(10);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpElementDatum>(entity =>
        {
            entity.HasKey(e => e.ElementId).HasName("PK_EmpElements");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ElementNameL1).HasMaxLength(50);
            entity.Property(e => e.ElementNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.MonthNotActive).HasDefaultValue(false);

            entity.HasOne(d => d.EmpElemntNatur).WithMany(p => p.EmpElementData)
                .HasForeignKey(d => d.EmpElemntNaturId)
                .HasConstraintName("FK_ElementData_EmpElementNature");

            entity.HasOne(d => d.EmpElemntType).WithMany(p => p.EmpElementData)
                .HasForeignKey(d => d.EmpElemntTypeId)
                .HasConstraintName("FK_ElementData_EmpElementType");
        });

        modelBuilder.Entity<EmpElementNature>(entity =>
        {
            entity.HasKey(e => e.ElementId).HasName("PK_ElementNature");

            entity.ToTable("EmpElementNature");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ElementNameL1).HasMaxLength(50);
            entity.Property(e => e.ElementNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpElementType>(entity =>
        {
            entity.HasKey(e => e.ElementId).HasName("PK_ElementType");

            entity.ToTable("EmpElementType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ElementNameL1).HasMaxLength(50);
            entity.Property(e => e.ElementNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpGroupWork>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_EmployeeWork");

            entity.ToTable("EmpGroupWork");

            entity.Property(e => e.GroupId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.GroupNameL1).HasMaxLength(50);
            entity.Property(e => e.GroupNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OnTime).HasPrecision(0);
            entity.Property(e => e.OnTimes).HasPrecision(0);
            entity.Property(e => e.OutTime).HasPrecision(0);
            entity.Property(e => e.OutTimes).HasPrecision(0);
            entity.Property(e => e.TotalDelayTime).HasPrecision(0);
            entity.Property(e => e.TotalEarlyTime).HasPrecision(0);
            entity.Property(e => e.TotalTime).HasPrecision(0);
            entity.Property(e => e.TotalTimeNotActive).HasDefaultValue(false);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.EmpGroupWorks)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmployeeWork_BranchesData");
        });

        modelBuilder.Entity<EmpLevel>(entity =>
        {
            entity.HasKey(e => e.LevelId);

            entity.ToTable("EmpLevel");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.EmpLevelType).WithMany(p => p.EmpLevels)
                .HasForeignKey(d => d.EmpLevelTypeId)
                .HasConstraintName("FK_EmpLevel_EmpLevelType");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.EmpLevels)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmpLevel_EmployeesData");
        });

        modelBuilder.Entity<EmpLevelType>(entity =>
        {
            entity.HasKey(e => e.LevelId).HasName("PK_EmpLeveltType");

            entity.ToTable("EmpLevelType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.LevelNameL1).HasMaxLength(20);
            entity.Property(e => e.LevelNameL2).HasMaxLength(20);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpLoan>(entity =>
        {
            entity.HasKey(e => e.LoansId);

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.EmpLoansType).WithMany(p => p.EmpLoans)
                .HasForeignKey(d => d.EmpLoansTypeId)
                .HasConstraintName("FK_EmpLoans_EmpLoansType");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.EmpLoans)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmpLoans_EmployeesData");
        });

        modelBuilder.Entity<EmpLoansType>(entity =>
        {
            entity.HasKey(e => e.LoansId).HasName("PK_EmpLoanstType");

            entity.ToTable("EmpLoansType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.LoansNameL1).HasMaxLength(20);
            entity.Property(e => e.LoansNameL2).HasMaxLength(20);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeCourse>(entity =>
        {
            entity.HasKey(e => e.EmployeeDetailsId).HasName("PK_EmployeeDetails");

            entity.ToTable("EmployeeCourse");

            entity.Property(e => e.EmployeeDetailsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Years).HasMaxLength(200);
        });

        modelBuilder.Entity<EmployeeDatum>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK_EmployeesData");

            entity.Property(e => e.EmployeeId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DateBarith).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.EducationeStimateId).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.EmployeeAddress).HasMaxLength(100);
            entity.Property(e => e.EmployeeEmail).HasMaxLength(50);
            entity.Property(e => e.EmployeeMobil).HasMaxLength(36);
            entity.Property(e => e.EmployeeNo).ValueGeneratedOnAdd();
            entity.Property(e => e.EmployeePhone).HasMaxLength(15);
            entity.Property(e => e.EmployeeWhatsapp).HasMaxLength(12);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.JobDataId).HasDefaultValue(0L);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(14);
            entity.Property(e => e.TimeEndWork).HasPrecision(4);
            entity.Property(e => e.TimeStartWork).HasPrecision(4);
            entity.Property(e => e.YareEducation).HasMaxLength(4);

            entity.HasOne(d => d.BranchesDataNavigation).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_EmployeeData_BranchesData");

            entity.HasOne(d => d.CityCode).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_EmployeesData_CityCode");

            entity.HasOne(d => d.Department).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_EmployeeData_Departments");

            entity.HasOne(d => d.EducationData).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.EducationDataId)
                .HasConstraintName("FK_EmployeesData_Education");

            entity.HasOne(d => d.EducationeStimate).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.EducationeStimateId)
                .HasConstraintName("FK_EmployeesData_Educationestimate");

            entity.HasOne(d => d.GenderData).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.GenderDataId)
                .HasConstraintName("FK_EmployeesData_Gender");

            entity.HasOne(d => d.GroupWork).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.GroupWorkId)
                .HasConstraintName("FK_EmployeesData_EmployeeWork");

            entity.HasOne(d => d.JobData).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.JobDataId)
                .HasConstraintName("FK_EmployeesData_JobData");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.PaymentTypeId)
                .HasConstraintName("FK_EmployeesData_PaymentType");

            entity.HasOne(d => d.RecruitmentData).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.RecruitmentDataId)
                .HasConstraintName("FK_EmployeesData_Recruitment");

            entity.HasOne(d => d.SocialData).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.SocialDataId)
                .HasConstraintName("FK_EmployeesData_SocialData");

            entity.HasOne(d => d.UniversityData).WithMany(p => p.EmployeeData)
                .HasForeignKey(d => d.UniversityDataId)
                .HasConstraintName("FK_EmployeesData_UniversityData");
        });

        modelBuilder.Entity<EmployeeJob>(entity =>
        {
            entity.ToTable("EmployeeJob");

            entity.Property(e => e.EmployeeJobId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.JobName).HasMaxLength(50);
            entity.Property(e => e.PayrollValue).HasDefaultValue(0.0);
            entity.Property(e => e.Time).HasMaxLength(12);

            entity.HasOne(d => d.EmployeeData).WithMany(p => p.EmployeeJobs)
                .HasForeignKey(d => d.EmployeeDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmployeeJob_EmployeeData");
        });

        modelBuilder.Entity<EmployeeSkill>(entity =>
        {
            entity.HasKey(e => e.SkillsId).HasName("PK_EmployeeSkills_1");

            entity.Property(e => e.SkillsId).ValueGeneratedNever();
            entity.Property(e => e.Darega).HasMaxLength(6);
            entity.Property(e => e.Descriptions).HasMaxLength(1000);
            entity.Property(e => e.SkillsName).HasMaxLength(50);

            entity.HasOne(d => d.EmployeeData).WithMany(p => p.EmployeeSkills)
                .HasForeignKey(d => d.EmployeeDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EmployeeSkills_EmployeeData");
        });

        modelBuilder.Entity<FinalDataFixed>(entity =>
        {
            entity.HasKey(e => e.FinalDataId).HasName("PK_FinalDataFixed_1");

            entity.ToTable("FinalDataFixed");

            entity.Property(e => e.FinalDataId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ActualDayes).HasColumnName("actualDayes");
            entity.Property(e => e.Allowance1)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance1");
            entity.Property(e => e.Allowance10)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance10");
            entity.Property(e => e.Allowance11)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance11");
            entity.Property(e => e.Allowance12).HasColumnName("allowance12");
            entity.Property(e => e.Allowance13).HasColumnName("allowance13");
            entity.Property(e => e.Allowance14).HasColumnName("allowance14");
            entity.Property(e => e.Allowance15).HasColumnName("allowance15");
            entity.Property(e => e.Allowance16).HasColumnName("allowance16");
            entity.Property(e => e.Allowance17).HasColumnName("allowance17");
            entity.Property(e => e.Allowance18).HasColumnName("allowance18");
            entity.Property(e => e.Allowance19).HasColumnName("allowance19");
            entity.Property(e => e.Allowance2)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance2");
            entity.Property(e => e.Allowance20).HasColumnName("allowance20");
            entity.Property(e => e.Allowance21).HasColumnName("allowance21");
            entity.Property(e => e.Allowance22).HasColumnName("allowance22");
            entity.Property(e => e.Allowance23).HasColumnName("allowance23");
            entity.Property(e => e.Allowance24).HasColumnName("allowance24");
            entity.Property(e => e.Allowance25).HasColumnName("allowance25");
            entity.Property(e => e.Allowance26).HasColumnName("allowance26");
            entity.Property(e => e.Allowance27).HasColumnName("allowance27");
            entity.Property(e => e.Allowance28).HasColumnName("allowance28");
            entity.Property(e => e.Allowance29).HasColumnName("allowance29");
            entity.Property(e => e.Allowance3)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance3");
            entity.Property(e => e.Allowance30).HasColumnName("allowance30");
            entity.Property(e => e.Allowance31).HasColumnName("allowance31");
            entity.Property(e => e.Allowance32).HasColumnName("allowance32");
            entity.Property(e => e.Allowance33).HasColumnName("allowance33");
            entity.Property(e => e.Allowance34).HasColumnName("allowance34");
            entity.Property(e => e.Allowance35).HasColumnName("allowance35");
            entity.Property(e => e.Allowance36).HasColumnName("allowance36");
            entity.Property(e => e.Allowance37).HasColumnName("allowance37");
            entity.Property(e => e.Allowance38).HasColumnName("allowance38");
            entity.Property(e => e.Allowance39).HasColumnName("allowance39");
            entity.Property(e => e.Allowance4)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance4");
            entity.Property(e => e.Allowance40).HasColumnName("allowance40");
            entity.Property(e => e.Allowance41)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance41");
            entity.Property(e => e.Allowance42)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance42");
            entity.Property(e => e.Allowance43)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance43");
            entity.Property(e => e.Allowance44)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance44");
            entity.Property(e => e.Allowance45)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance45");
            entity.Property(e => e.Allowance46)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance46");
            entity.Property(e => e.Allowance47)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance47");
            entity.Property(e => e.Allowance48)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance48");
            entity.Property(e => e.Allowance49)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance49");
            entity.Property(e => e.Allowance5)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance5");
            entity.Property(e => e.Allowance50)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance50");
            entity.Property(e => e.Allowance51)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance51");
            entity.Property(e => e.Allowance52)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance52");
            entity.Property(e => e.Allowance53)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance53");
            entity.Property(e => e.Allowance54)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance54");
            entity.Property(e => e.Allowance55)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance55");
            entity.Property(e => e.Allowance56)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance56");
            entity.Property(e => e.Allowance57)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance57");
            entity.Property(e => e.Allowance58)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance58");
            entity.Property(e => e.Allowance59)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance59");
            entity.Property(e => e.Allowance6)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance6");
            entity.Property(e => e.Allowance60)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance60");
            entity.Property(e => e.Allowance7)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance7");
            entity.Property(e => e.Allowance8)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance8");
            entity.Property(e => e.Allowance9)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance9");
            entity.Property(e => e.Basicsalary).HasColumnName("basicsalary");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Deduction1).HasColumnName("deduction1");
            entity.Property(e => e.Deduction10).HasColumnName("deduction10");
            entity.Property(e => e.Deduction11).HasColumnName("deduction11");
            entity.Property(e => e.Deduction12).HasColumnName("deduction12");
            entity.Property(e => e.Deduction13).HasColumnName("deduction13");
            entity.Property(e => e.Deduction14).HasColumnName("deduction14");
            entity.Property(e => e.Deduction15).HasColumnName("deduction15");
            entity.Property(e => e.Deduction16).HasColumnName("deduction16");
            entity.Property(e => e.Deduction17).HasColumnName("deduction17");
            entity.Property(e => e.Deduction18).HasColumnName("deduction18");
            entity.Property(e => e.Deduction19).HasColumnName("deduction19");
            entity.Property(e => e.Deduction2).HasColumnName("deduction2");
            entity.Property(e => e.Deduction20).HasColumnName("deduction20");
            entity.Property(e => e.Deduction21).HasColumnName("deduction21");
            entity.Property(e => e.Deduction22).HasColumnName("deduction22");
            entity.Property(e => e.Deduction23).HasColumnName("deduction23");
            entity.Property(e => e.Deduction24).HasColumnName("deduction24");
            entity.Property(e => e.Deduction25).HasColumnName("deduction25");
            entity.Property(e => e.Deduction26).HasColumnName("deduction26");
            entity.Property(e => e.Deduction27).HasColumnName("deduction27");
            entity.Property(e => e.Deduction28).HasColumnName("deduction28");
            entity.Property(e => e.Deduction29).HasColumnName("deduction29");
            entity.Property(e => e.Deduction3).HasColumnName("deduction3");
            entity.Property(e => e.Deduction30).HasColumnName("deduction30");
            entity.Property(e => e.Deduction31).HasColumnName("deduction31");
            entity.Property(e => e.Deduction32).HasColumnName("deduction32");
            entity.Property(e => e.Deduction33).HasColumnName("deduction33");
            entity.Property(e => e.Deduction34).HasColumnName("deduction34");
            entity.Property(e => e.Deduction35).HasColumnName("deduction35");
            entity.Property(e => e.Deduction36).HasColumnName("deduction36");
            entity.Property(e => e.Deduction37).HasColumnName("deduction37");
            entity.Property(e => e.Deduction38).HasColumnName("deduction38");
            entity.Property(e => e.Deduction39).HasColumnName("deduction39");
            entity.Property(e => e.Deduction4).HasColumnName("deduction4");
            entity.Property(e => e.Deduction40).HasColumnName("deduction40");
            entity.Property(e => e.Deduction41)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction41");
            entity.Property(e => e.Deduction42)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction42");
            entity.Property(e => e.Deduction43)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction43");
            entity.Property(e => e.Deduction44)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction44");
            entity.Property(e => e.Deduction45)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction45");
            entity.Property(e => e.Deduction46)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction46");
            entity.Property(e => e.Deduction47)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction47");
            entity.Property(e => e.Deduction48)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction48");
            entity.Property(e => e.Deduction49)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction49");
            entity.Property(e => e.Deduction5).HasColumnName("deduction5");
            entity.Property(e => e.Deduction50)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction50");
            entity.Property(e => e.Deduction51)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction51");
            entity.Property(e => e.Deduction52)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction52");
            entity.Property(e => e.Deduction53)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction53");
            entity.Property(e => e.Deduction54)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction54");
            entity.Property(e => e.Deduction55)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction55");
            entity.Property(e => e.Deduction56)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction56");
            entity.Property(e => e.Deduction57)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction57");
            entity.Property(e => e.Deduction58)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction58");
            entity.Property(e => e.Deduction59)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction59");
            entity.Property(e => e.Deduction6).HasColumnName("deduction6");
            entity.Property(e => e.Deduction60)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction60");
            entity.Property(e => e.Deduction7).HasColumnName("deduction7");
            entity.Property(e => e.Deduction8).HasColumnName("deduction8");
            entity.Property(e => e.Deduction9).HasColumnName("deduction9");
            entity.Property(e => e.DeductionSum).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation1).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation2).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation3).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation4).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation5).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NSalaryExchanged).HasColumnName("nSalaryExchanged");
            entity.Property(e => e.TaxExemptBool).HasColumnName("Tax_ExemptBool");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.FinalDataFixeds)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinalDataFixed_EmployeeData");
        });

        modelBuilder.Entity<FinalDatum>(entity =>
        {
            entity.HasKey(e => e.FinalDataId);

            entity.Property(e => e.FinalDataId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ActualDayes).HasColumnName("actualDayes");
            entity.Property(e => e.Allowance1)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance1");
            entity.Property(e => e.Allowance10)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance10");
            entity.Property(e => e.Allowance11)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance11");
            entity.Property(e => e.Allowance12).HasColumnName("allowance12");
            entity.Property(e => e.Allowance13).HasColumnName("allowance13");
            entity.Property(e => e.Allowance14).HasColumnName("allowance14");
            entity.Property(e => e.Allowance15).HasColumnName("allowance15");
            entity.Property(e => e.Allowance16).HasColumnName("allowance16");
            entity.Property(e => e.Allowance17).HasColumnName("allowance17");
            entity.Property(e => e.Allowance18).HasColumnName("allowance18");
            entity.Property(e => e.Allowance19).HasColumnName("allowance19");
            entity.Property(e => e.Allowance2)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance2");
            entity.Property(e => e.Allowance20).HasColumnName("allowance20");
            entity.Property(e => e.Allowance21).HasColumnName("allowance21");
            entity.Property(e => e.Allowance22).HasColumnName("allowance22");
            entity.Property(e => e.Allowance23).HasColumnName("allowance23");
            entity.Property(e => e.Allowance24).HasColumnName("allowance24");
            entity.Property(e => e.Allowance25).HasColumnName("allowance25");
            entity.Property(e => e.Allowance26).HasColumnName("allowance26");
            entity.Property(e => e.Allowance27).HasColumnName("allowance27");
            entity.Property(e => e.Allowance28).HasColumnName("allowance28");
            entity.Property(e => e.Allowance29).HasColumnName("allowance29");
            entity.Property(e => e.Allowance3)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance3");
            entity.Property(e => e.Allowance30).HasColumnName("allowance30");
            entity.Property(e => e.Allowance31).HasColumnName("allowance31");
            entity.Property(e => e.Allowance32).HasColumnName("allowance32");
            entity.Property(e => e.Allowance33).HasColumnName("allowance33");
            entity.Property(e => e.Allowance34).HasColumnName("allowance34");
            entity.Property(e => e.Allowance35).HasColumnName("allowance35");
            entity.Property(e => e.Allowance36).HasColumnName("allowance36");
            entity.Property(e => e.Allowance37).HasColumnName("allowance37");
            entity.Property(e => e.Allowance38).HasColumnName("allowance38");
            entity.Property(e => e.Allowance39).HasColumnName("allowance39");
            entity.Property(e => e.Allowance4)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance4");
            entity.Property(e => e.Allowance40).HasColumnName("allowance40");
            entity.Property(e => e.Allowance41)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance41");
            entity.Property(e => e.Allowance42)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance42");
            entity.Property(e => e.Allowance43)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance43");
            entity.Property(e => e.Allowance44)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance44");
            entity.Property(e => e.Allowance45)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance45");
            entity.Property(e => e.Allowance46)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance46");
            entity.Property(e => e.Allowance47)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance47");
            entity.Property(e => e.Allowance48)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance48");
            entity.Property(e => e.Allowance49)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance49");
            entity.Property(e => e.Allowance5)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance5");
            entity.Property(e => e.Allowance50)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance50");
            entity.Property(e => e.Allowance51)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance51");
            entity.Property(e => e.Allowance52)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance52");
            entity.Property(e => e.Allowance53)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance53");
            entity.Property(e => e.Allowance54)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance54");
            entity.Property(e => e.Allowance55)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance55");
            entity.Property(e => e.Allowance56)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance56");
            entity.Property(e => e.Allowance57)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance57");
            entity.Property(e => e.Allowance58)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance58");
            entity.Property(e => e.Allowance59)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance59");
            entity.Property(e => e.Allowance6)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance6");
            entity.Property(e => e.Allowance60)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance60");
            entity.Property(e => e.Allowance7)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance7");
            entity.Property(e => e.Allowance8)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance8");
            entity.Property(e => e.Allowance9)
                .HasDefaultValue(0.0)
                .HasColumnName("allowance9");
            entity.Property(e => e.Basicsalary).HasColumnName("basicsalary");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Deduction1).HasColumnName("deduction1");
            entity.Property(e => e.Deduction10).HasColumnName("deduction10");
            entity.Property(e => e.Deduction11).HasColumnName("deduction11");
            entity.Property(e => e.Deduction12).HasColumnName("deduction12");
            entity.Property(e => e.Deduction13).HasColumnName("deduction13");
            entity.Property(e => e.Deduction14).HasColumnName("deduction14");
            entity.Property(e => e.Deduction15).HasColumnName("deduction15");
            entity.Property(e => e.Deduction16).HasColumnName("deduction16");
            entity.Property(e => e.Deduction17).HasColumnName("deduction17");
            entity.Property(e => e.Deduction18).HasColumnName("deduction18");
            entity.Property(e => e.Deduction19).HasColumnName("deduction19");
            entity.Property(e => e.Deduction2).HasColumnName("deduction2");
            entity.Property(e => e.Deduction20).HasColumnName("deduction20");
            entity.Property(e => e.Deduction21).HasColumnName("deduction21");
            entity.Property(e => e.Deduction22).HasColumnName("deduction22");
            entity.Property(e => e.Deduction23).HasColumnName("deduction23");
            entity.Property(e => e.Deduction24).HasColumnName("deduction24");
            entity.Property(e => e.Deduction25).HasColumnName("deduction25");
            entity.Property(e => e.Deduction26).HasColumnName("deduction26");
            entity.Property(e => e.Deduction27).HasColumnName("deduction27");
            entity.Property(e => e.Deduction28).HasColumnName("deduction28");
            entity.Property(e => e.Deduction29).HasColumnName("deduction29");
            entity.Property(e => e.Deduction3).HasColumnName("deduction3");
            entity.Property(e => e.Deduction30).HasColumnName("deduction30");
            entity.Property(e => e.Deduction31).HasColumnName("deduction31");
            entity.Property(e => e.Deduction32).HasColumnName("deduction32");
            entity.Property(e => e.Deduction33).HasColumnName("deduction33");
            entity.Property(e => e.Deduction34).HasColumnName("deduction34");
            entity.Property(e => e.Deduction35).HasColumnName("deduction35");
            entity.Property(e => e.Deduction36).HasColumnName("deduction36");
            entity.Property(e => e.Deduction37).HasColumnName("deduction37");
            entity.Property(e => e.Deduction38).HasColumnName("deduction38");
            entity.Property(e => e.Deduction39).HasColumnName("deduction39");
            entity.Property(e => e.Deduction4).HasColumnName("deduction4");
            entity.Property(e => e.Deduction40).HasColumnName("deduction40");
            entity.Property(e => e.Deduction41)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction41");
            entity.Property(e => e.Deduction42)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction42");
            entity.Property(e => e.Deduction43)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction43");
            entity.Property(e => e.Deduction44)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction44");
            entity.Property(e => e.Deduction45)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction45");
            entity.Property(e => e.Deduction46)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction46");
            entity.Property(e => e.Deduction47)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction47");
            entity.Property(e => e.Deduction48)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction48");
            entity.Property(e => e.Deduction49)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction49");
            entity.Property(e => e.Deduction5).HasColumnName("deduction5");
            entity.Property(e => e.Deduction50)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction50");
            entity.Property(e => e.Deduction51)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction51");
            entity.Property(e => e.Deduction52)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction52");
            entity.Property(e => e.Deduction53)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction53");
            entity.Property(e => e.Deduction54)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction54");
            entity.Property(e => e.Deduction55)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction55");
            entity.Property(e => e.Deduction56)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction56");
            entity.Property(e => e.Deduction57)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction57");
            entity.Property(e => e.Deduction58)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction58");
            entity.Property(e => e.Deduction59)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction59");
            entity.Property(e => e.Deduction6).HasColumnName("deduction6");
            entity.Property(e => e.Deduction60)
                .HasDefaultValue(0.0)
                .HasColumnName("deduction60");
            entity.Property(e => e.Deduction7).HasColumnName("deduction7");
            entity.Property(e => e.Deduction8).HasColumnName("deduction8");
            entity.Property(e => e.Deduction9).HasColumnName("deduction9");
            entity.Property(e => e.DeductionSum).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation1).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation2).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation3).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation4).HasMaxLength(50);
            entity.Property(e => e.GenralDescripation5).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NSalaryExchanged).HasColumnName("nSalaryExchanged");
            entity.Property(e => e.TaxExemptBool).HasColumnName("Tax_ExemptBool");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.FinalData)
                .HasForeignKey(d => d.EmployeesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinalData_EmployeesData");
        });

        modelBuilder.Entity<FinancialCenter>(entity =>
        {
            entity.HasKey(e => e.FinancialCenter1);

            entity.ToTable("FinancialCenter");

            entity.Property(e => e.FinancialCenter1)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("FinancialCenter");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FinancialNo).ValueGeneratedOnAdd();
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalCredit).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDebit).HasDefaultValue(0.0);

            entity.HasOne(d => d.AccountFication).WithMany(p => p.FinancialCenters)
                .HasForeignKey(d => d.AccountFicationId)
                .HasConstraintName("FK_FinancialCenter_AccountFication");

            entity.HasOne(d => d.AccountName).WithMany(p => p.FinancialCenters)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_FinancialCenter_AccountName");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.FinancialCenters)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinancialCenter_CompanyData");
        });

        modelBuilder.Entity<GenderDatum>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK_Gender");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.GenderNameL1).HasMaxLength(50);
            entity.Property(e => e.GenderNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<GeneralAccountFooter>(entity =>
        {
            entity.HasKey(e => e.GeneralAccountFooterId).HasName("PK_GeneralAccountFooter_1");

            entity.ToTable("GeneralAccountFooter");

            entity.Property(e => e.GeneralAccountFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Balance).HasDefaultValue(0.0);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AccountName).WithMany(p => p.GeneralAccountFooters)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_GeneralAccountFooter_AccountName");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.GeneralAccountFooters)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_GeneralAccountFooter_CostCenter");

            entity.HasOne(d => d.GeneralAccountHeader).WithMany(p => p.GeneralAccountFooters)
                .HasForeignKey(d => d.GeneralAccountHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GeneralAccountFooter_GeneralAccountHeader");
        });

        modelBuilder.Entity<GeneralAccountHeader>(entity =>
        {
            entity.HasKey(e => e.GeneralAccountHeaderId).HasName("PK_GeneralAccountHeader_1");

            entity.ToTable("GeneralAccountHeader");

            entity.Property(e => e.GeneralAccountHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalBalance).HasDefaultValue(0.0);
            entity.Property(e => e.TotalCrdit).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDebit).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.GeneralAccountHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GeneralAccountHeader_BranchesData");
        });

        modelBuilder.Entity<GeneralAccountType>(entity =>
        {
            entity.ToTable("GeneralAccountType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.GeneralAccountTypeNameL1).HasMaxLength(50);
            entity.Property(e => e.GeneralAccountTypeNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<GovernorateCode>(entity =>
        {
            entity.HasKey(e => e.GovernorateId);

            entity.ToTable("GovernorateCode");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.GovernorateNameL1).HasMaxLength(75);
            entity.Property(e => e.GovernorateNameL2).HasMaxLength(75);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Posted).HasDefaultValue(false);

            entity.HasOne(d => d.CountryCode).WithMany(p => p.GovernorateCodes)
                .HasForeignKey(d => d.CountryCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GovernorateCode_CountryCode");
        });

        modelBuilder.Entity<HomePage>(entity =>
        {
            entity.HasKey(e => e.HomeId);

            entity.ToTable("HomePage");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<HotelPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("Hotel_Payment");

            entity.Property(e => e.PaymentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.HotelPayments)
                .HasForeignKey(d => d.CompanyDataId)
                .HasConstraintName("FK_Hotel_Payment_CompanyData");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.HotelPayments)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Hotel_Payment_CustomerData");

            entity.HasOne(d => d.HotelReservationMaster).WithMany(p => p.HotelPayments)
                .HasForeignKey(d => d.HotelReservationMasterId)
                .HasConstraintName("FK_Hotel_Payment_Hotel_ReservationMaster");
        });

        modelBuilder.Entity<HotelReservationDetail>(entity =>
        {
            entity.HasKey(e => e.ReservationDetailsId);

            entity.ToTable("Hotel_ReservationDetails");

            entity.Property(e => e.ReservationDetailsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Discount).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.ReservationValue).HasDefaultValue(0.0);
            entity.Property(e => e.ServicesValue).HasDefaultValue(0.0);
            entity.Property(e => e.Tax).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.ReservationMaster).WithMany(p => p.HotelReservationDetails)
                .HasForeignKey(d => d.ReservationMasterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Hotel_ReservationDetails_Hotel_ReservationMaster");

            entity.HasOne(d => d.Services).WithMany(p => p.HotelReservationDetails)
                .HasForeignKey(d => d.ServicesId)
                .HasConstraintName("FK_Hotel_ReservationDetails_Hotel_Services");
        });

        modelBuilder.Entity<HotelReservationMaster>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK_Hotel_Reservation");

            entity.ToTable("Hotel_ReservationMaster");

            entity.Property(e => e.ReservationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReservationValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.CustomerData).WithMany(p => p.HotelReservationMasters)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Hotel_Reservation_CustomerData");

            entity.HasOne(d => d.Room).WithMany(p => p.HotelReservationMasters)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_Hotel_Reservation_Hotel_RoomData");
        });

        modelBuilder.Entity<HotelRoomDatum>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK_RoomData_1");

            entity.ToTable("Hotel_RoomData");

            entity.Property(e => e.RoomId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.RoomNumber).HasMaxLength(10);
            entity.Property(e => e.RoomValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.HotelRoomData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RoomData_CompanyData");
        });

        modelBuilder.Entity<HotelService>(entity =>
        {
            entity.HasKey(e => e.ServicesId);

            entity.ToTable("Hotel_Services");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ServicesNameL1).HasMaxLength(50);
            entity.Property(e => e.ServicesNameL2).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.HotelServices)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Hotel_Services_CompanyData");
        });

        modelBuilder.Entity<InstallmentFooter>(entity =>
        {
            entity.ToTable("InstallmentFooter");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            entity.Property(e => e.PostedInstallment).HasDefaultValue(false);

            entity.HasOne(d => d.InstallmentHeader).WithMany(p => p.InstallmentFooters)
                .HasForeignKey(d => d.InstallmentHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InstallmentFooter_InstallmentHeader");
        });

        modelBuilder.Entity<InstallmentHeader>(entity =>
        {
            entity.ToTable("InstallmentHeader");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DelayInterestRate).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InterestRate).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.InstallmentHeaders)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InstallmentHeader_CustomerData");
        });

        modelBuilder.Entity<InventoryOrderFooter>(entity =>
        {
            entity.HasKey(e => e.InventoryOrderFooterId).HasName("PK_PurchaseOrderFooter");

            entity.ToTable("InventoryOrderFooter");

            entity.Property(e => e.InventoryOrderFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.InventoryOrderHeader).WithMany(p => p.InventoryOrderFooters)
                .HasForeignKey(d => d.InventoryOrderHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InventoryOrderFooter_InventoryOrderHeader");

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.InventoryOrderFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_InventoryOrderFooter_ItemsHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.InventoryOrderFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_InventoryOrderFooter_UnitType");
        });

        modelBuilder.Entity<InventoryOrderHeader>(entity =>
        {
            entity.HasKey(e => e.InventoryOrderHeaderId).HasName("PK_PurchaseOrderHeader");

            entity.ToTable("InventoryOrderHeader");

            entity.Property(e => e.InventoryOrderHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OrderNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.InventoryOrderHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InventoryOrderHeader_BranchesData");

            entity.HasOne(d => d.StoreData).WithMany(p => p.InventoryOrderHeaders)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_InventoryOrderHeader_StoreData");
        });

        modelBuilder.Entity<InventoryValuation>(entity =>
        {
            entity.HasKey(e => e.ValuationId);

            entity.ToTable("InventoryValuation");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ValuationNameL1).HasMaxLength(50);
            entity.Property(e => e.ValuationNameL2).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoicingResult>(entity =>
        {
            entity.ToTable("InvoicingResult");

            entity.Property(e => e.CreateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.HashKey).HasMaxLength(50);
            entity.Property(e => e.InternalId).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.LongId).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Uuid).HasMaxLength(50);
        });

        modelBuilder.Entity<ItemsBalancFooter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemsBalancFooter");

            entity.Property(e => e.BalanceNameL1).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.StoreName).HasMaxLength(50);
            entity.Property(e => e.UnitNameL1).HasMaxLength(70);
        });

        modelBuilder.Entity<ItemsBalanceFooter>(entity =>
        {
            entity.HasKey(e => e.ItemsBalanceId);

            entity.ToTable("ItemsBalanceFooter");

            entity.Property(e => e.ItemsBalanceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.InternationalBarCode).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ItemQuantity).HasDefaultValue(0.0);
            entity.Property(e => e.ItemQuantityBroken).HasDefaultValue(0.0);
            entity.Property(e => e.ItemQuantityDamaged).HasDefaultValue(0.0);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.SupplierBarCode).HasMaxLength(50);

            entity.HasOne(d => d.ItemsBalanceHeader).WithMany(p => p.ItemsBalanceFooters)
                .HasForeignKey(d => d.ItemsBalanceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsBalanceFooter_ItemsBalanceHeader");

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ItemsBalanceFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_ItemsBalanceFooter_ItemsHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.ItemsBalanceFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_ItemsBalanceFooter_UnitType");
        });

        modelBuilder.Entity<ItemsBalanceHeader>(entity =>
        {
            entity.HasKey(e => e.BalanceHeaderId).HasName("PK_ItemsBalanceHeader_1");

            entity.ToTable("ItemsBalanceHeader");

            entity.Property(e => e.BalanceHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemsBalanceHeaderId).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BalanceName).WithMany(p => p.ItemsBalanceHeaders)
                .HasForeignKey(d => d.BalanceNameId)
                .HasConstraintName("FK_ItemsBalanceHeader_BalanceName");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.ItemsBalanceHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsBalanceHeader_BranchesData");

            entity.HasOne(d => d.StoreData).WithMany(p => p.ItemsBalanceHeaders)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_ItemsBalanceHeader_StoreData");
        });

        modelBuilder.Entity<ItemsCodeType>(entity =>
        {
            entity.HasKey(e => e.CodeId);

            entity.ToTable("ItemsCodeType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemCodeNameL1).HasMaxLength(5);
            entity.Property(e => e.ItemCodeNameL2).HasMaxLength(5);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<ItemsColor>(entity =>
        {
            entity.ToTable("ItemsColor");

            entity.Property(e => e.ItemsColorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.ColorType).WithMany(p => p.ItemsColors)
                .HasForeignKey(d => d.ColorTypeId)
                .HasConstraintName("FK_ItemsColor_ColorType");

            entity.HasOne(d => d.ItemHeader).WithMany(p => p.ItemsColors)
                .HasForeignKey(d => d.ItemHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsColor_ItemsHeader");

            entity.HasOne(d => d.SizeType).WithMany(p => p.ItemsColors)
                .HasForeignKey(d => d.SizeTypeId)
                .HasConstraintName("FK_ItemsColor_SizeType");
        });

        modelBuilder.Entity<ItemsGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupId);

            entity.ToTable("ItemsGroup");

            entity.Property(e => e.ItemGroupId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemCodeTax).HasMaxLength(20);
            entity.Property(e => e.ItemGroupNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemGroupNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ItemsGroups)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsGroup_CompanyData");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_ItemsGroup_ItemsGroup");
        });

        modelBuilder.Entity<ItemsHeader>(entity =>
        {
            entity.HasKey(e => e.ItemHeaderId);

            entity.ToTable("ItemsHeader");

            entity.Property(e => e.ItemHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.InternationalBarCode).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsNotActiveTax).HasDefaultValue(false);
            entity.Property(e => e.IsNotActiveTaxDiscount).HasDefaultValue(false);
            entity.Property(e => e.ItemPrice1).HasDefaultValue(0.0);
            entity.Property(e => e.ItemPrice2).HasDefaultValue(0.0);
            entity.Property(e => e.ItemPrice3).HasDefaultValue(0.0);
            entity.Property(e => e.ItemPrice4).HasDefaultValue(0.0);
            entity.Property(e => e.ItemPrice5).HasDefaultValue(0.0);
            entity.Property(e => e.ItemPriceCost).HasDefaultValue(0.0);
            entity.Property(e => e.ItemPricePurchase).HasDefaultValue(0.0);
            entity.Property(e => e.ItemProfit1).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.SupplierBarCode).HasMaxLength(50);

            entity.HasOne(d => d.ItemsCodeType).WithMany(p => p.ItemsHeaders)
                .HasForeignKey(d => d.ItemsCodeTypeId)
                .HasConstraintName("FK_ItemsHeader_ItemsCodeType");

            entity.HasOne(d => d.ItemsGroups).WithMany(p => p.ItemsHeaders)
                .HasForeignKey(d => d.ItemsGroupsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsHeader_ItemsGroup");

            entity.HasOne(d => d.ItemsType).WithMany(p => p.ItemsHeaders)
                .HasForeignKey(d => d.ItemsTypeId)
                .HasConstraintName("FK_ItemsHeader_ItemsType");

            entity.HasOne(d => d.SupplierData).WithMany(p => p.ItemsHeaders)
                .HasForeignKey(d => d.SupplierDataId)
                .HasConstraintName("FK_ItemsHeader_SupplierData");

            entity.HasOne(d => d.UnitType).WithMany(p => p.ItemsHeaders)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_ItemsHeader_UnitType");
        });

        modelBuilder.Entity<ItemsPricePurchase>(entity =>
        {
            entity.HasKey(e => e.ItemsHistoryPurchasesId).HasName("PK_ItemsHistoryPu");

            entity.Property(e => e.ItemsHistoryPurchasesId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DatePurchases).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemsPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ItemsPricePurchases)
                .HasForeignKey(d => d.ItemsHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsPricePurchases_ItemsHeader");

            entity.HasOne(d => d.SupplierData).WithMany(p => p.ItemsPricePurchases)
                .HasForeignKey(d => d.SupplierDataId)
                .HasConstraintName("FK_ItemsPricePurchases_SupplierData");
        });

        modelBuilder.Entity<ItemsPricePurchasesSupplier>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemsPricePurchasesSuppliers");

            entity.Property(e => e.DatePurchases).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.SupplierName).HasMaxLength(75);
        });

        modelBuilder.Entity<ItemsPriceSale>(entity =>
        {
            entity.HasKey(e => e.ItemsPriceId).HasName("PK_ItemsFooter");

            entity.Property(e => e.ItemsPriceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DateSales).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PriceValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ItemsPriceSales)
                .HasForeignKey(d => d.ItemsHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsPriceSales_ItemsHeader");

            entity.HasOne(d => d.PriceType).WithMany(p => p.ItemsPriceSales)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("FK_ItemsPriceSales_PriceType");

            entity.HasOne(d => d.UnitType).WithMany(p => p.ItemsPriceSales)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_ItemsPriceSales_UnitType");
        });

        modelBuilder.Entity<ItemsPriceSalesMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemsPriceSalesMenu");

            entity.Property(e => e.DateSales).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.PriceNameL1).HasMaxLength(50);
            entity.Property(e => e.UnitNameL1).HasMaxLength(70);
        });

        modelBuilder.Entity<ItemsProduction>(entity =>
        {
            entity.HasKey(e => e.ItemsProductionId).HasName("PK_ItemsDetails");

            entity.ToTable("ItemsProduction");

            entity.Property(e => e.ItemsProductionId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ItemsProductions)
                .HasForeignKey(d => d.ItemsHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsProduction_ItemsHeader");
        });

        modelBuilder.Entity<ItemsSize>(entity =>
        {
            entity.HasKey(e => e.ItemsSizeId).HasName("PK_ItemsSize_1");

            entity.ToTable("ItemsSize");

            entity.Property(e => e.ItemsSizeId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.SizeValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemHeader).WithMany(p => p.ItemsSizes)
                .HasForeignKey(d => d.ItemHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsSize_ItemsHeader");

            entity.HasOne(d => d.SizeType).WithMany(p => p.ItemsSizes)
                .HasForeignKey(d => d.SizeTypeId)
                .HasConstraintName("FK_ItemsSize_SizeType");
        });

        modelBuilder.Entity<ItemsStock>(entity =>
        {
            entity.ToTable("ItemsStock");

            entity.Property(e => e.ItemsStockId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);

            entity.HasOne(d => d.AdditionAdjustment).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.AdditionAdjustmentId)
                .HasConstraintName("FK_ItemsStock_AdditionAdjustment");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItemsStock_BranchesData");

            entity.HasOne(d => d.ItemsBalanceFooter).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.ItemsBalanceFooterId)
                .HasConstraintName("FK_ItemsStock_ItemsBalanceFooter");

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_ItemsStock_ItemsHeader");

            entity.HasOne(d => d.RequestReceiptFooter).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.RequestReceiptFooterId)
                .HasConstraintName("FK_ItemsStock_RequestReceiptFooter");

            entity.HasOne(d => d.ReturnPurchasesFooter).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.ReturnPurchasesFooterId)
                .HasConstraintName("FK_ItemsStock_ReturnPurchasesFooter");

            entity.HasOne(d => d.ReturnSalesFooter).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.ReturnSalesFooterId)
                .HasConstraintName("FK_ItemsStock_ReturnSalesFooter");

            entity.HasOne(d => d.SalesInvoiceFooter).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.SalesInvoiceFooterId)
                .HasConstraintName("FK_ItemsStock_SalesInvoiceFooter");

            entity.HasOne(d => d.SettlementDiscount).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.SettlementDiscountId)
                .HasConstraintName("FK_ItemsStock_SettlementDiscount");

            entity.HasOne(d => d.StoreData).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_ItemsStock_StoreData");

            entity.HasOne(d => d.TransformationsDetail).WithMany(p => p.ItemsStocks)
                .HasForeignKey(d => d.TransformationsDetailId)
                .HasConstraintName("FK_ItemsStock_TransformationsDetails");
        });

        modelBuilder.Entity<ItemsType>(entity =>
        {
            entity.ToTable("ItemsType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemsTypeNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemsTypeNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<JobDatum>(entity =>
        {
            entity.HasKey(e => e.JobDataId).HasName("PK_JobName");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.JobDatanameL1).HasMaxLength(30);
            entity.Property(e => e.JobDatanameL2).HasMaxLength(30);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<JournalEntriesType>(entity =>
        {
            entity.HasKey(e => e.EntriesId);

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(20);
            entity.Property(e => e.CreateUserName).HasMaxLength(20);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(20);
            entity.Property(e => e.EntriesNameL1).HasMaxLength(50);
            entity.Property(e => e.EntriesNameL2).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(20);
        });

        modelBuilder.Entity<JournalFooter>(entity =>
        {
            entity.ToTable("JournalFooter");

            entity.Property(e => e.JournalFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Balance).HasDefaultValue(0.0);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AccountName).WithMany(p => p.JournalFooters)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_JournalFooter_AccountName");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.JournalFooters)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_JournalFooter_CostElement");

            entity.HasOne(d => d.JournalHeader).WithMany(p => p.JournalFooters)
                .HasForeignKey(d => d.JournalHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_JournalFooter_JournalHeader");
        });

        modelBuilder.Entity<JournalHeader>(entity =>
        {
            entity.HasKey(e => e.JournalHeaderId).HasName("PK_JournalHeader_1");

            entity.ToTable("JournalHeader");

            entity.Property(e => e.JournalHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.JournalNo).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalBalance).HasDefaultValue(0.0);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.JournalHeaders)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_JournalHeader_CompanyData");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.JournalHeaders)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_JournalHeader_CurrencyData");
        });

        modelBuilder.Entity<Key>(entity =>
        {
            entity.Property(e => e.Algorithm)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Data).IsRequired();
            entity.Property(e => e.IsX509certificate).HasColumnName("IsX509Certificate");
            entity.Property(e => e.Use).HasMaxLength(450);
        });

        modelBuilder.Entity<LockersBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LockersBalance");

            entity.Property(e => e.AccountNameL1).HasMaxLength(100);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.LockersNameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<LockersDatum>(entity =>
        {
            entity.HasKey(e => e.LockersId).HasName("PK_LockersDat");

            entity.Property(e => e.LockersId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.LockersNameL1).HasMaxLength(50);
            entity.Property(e => e.LockersNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AccountName).WithMany(p => p.LockersData)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_LockersData_AccountName");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.LockersData)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_LockersDat_BranchesData");
        });

        modelBuilder.Entity<MedAnalysisName>(entity =>
        {
            entity.HasKey(e => e.AnalysisNameId);

            entity.ToTable("Med_AnalysisNames");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.MedAnalysisNames)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_AnalysisNames_BranchesData");
        });

        modelBuilder.Entity<MedCustomerDetail>(entity =>
        {
            entity.HasKey(e => e.DetailsId);

            entity.ToTable("Med_CustomerDetails");

            entity.Property(e => e.DetailsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.AnalysisName).WithMany(p => p.MedCustomerDetails)
                .HasForeignKey(d => d.AnalysisNameId)
                .HasConstraintName("FK_Med_CustomerDetails_Med_AnalysisNames");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.MedCustomerDetails)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_CustomerDetails_CustomerData");

            entity.HasOne(d => d.RaysName).WithMany(p => p.MedCustomerDetails)
                .HasForeignKey(d => d.RaysNameId)
                .HasConstraintName("FK_Med_CustomerDetails_Med_RaysName");
        });

        modelBuilder.Entity<MedCustomerMedicalService>(entity =>
        {
            entity.HasKey(e => e.CustomerServicesId);

            entity.ToTable("Med_CustomerMedicalServices");

            entity.Property(e => e.CustomerServicesId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CustomerData).WithMany(p => p.MedCustomerMedicalServices)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_CustomerMedicalServices_CustomerData");

            entity.HasOne(d => d.MedicalServices).WithMany(p => p.MedCustomerMedicalServices)
                .HasForeignKey(d => d.MedicalServicesId)
                .HasConstraintName("FK_Med_CustomerMedicalServices_Med_MedicalServices");
        });

        modelBuilder.Entity<MedCustomerSurgicalService>(entity =>
        {
            entity.HasKey(e => e.CustomerSurgicalServicesId);

            entity.ToTable("Med_CustomerSurgicalServices");

            entity.Property(e => e.CustomerSurgicalServicesId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.MedCustomerSurgicalServices)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_CustomerSurgicalServices_CustomerData");

            entity.HasOne(d => d.SurgicalServices).WithMany(p => p.MedCustomerSurgicalServices)
                .HasForeignKey(d => d.SurgicalServicesId)
                .HasConstraintName("FK_Med_CustomerSurgicalServices_Med_SurgicalServices");
        });

        modelBuilder.Entity<MedMedicalService>(entity =>
        {
            entity.HasKey(e => e.MedicalServicesId);

            entity.ToTable("Med_MedicalServices");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.MedicalServicesValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.MedMedicalServices)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_MedicalServices_BranchesData");
        });

        modelBuilder.Entity<MedPartnerDatum>(entity =>
        {
            entity.HasKey(e => e.PartnerDataId);

            entity.ToTable("Med_PartnerData");

            entity.Property(e => e.PartnerDataId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PartnerAddress).HasMaxLength(100);
            entity.Property(e => e.PartnerDataBarCode)
                .HasMaxLength(20)
                .HasDefaultValue("(newid())");
            entity.Property(e => e.PartnerDataNameL1).HasMaxLength(100);
            entity.Property(e => e.PartnerDataNameL2).HasMaxLength(100);
            entity.Property(e => e.PartnerDataNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.PartnerEmail).HasMaxLength(50);
            entity.Property(e => e.PartnerMobil).HasMaxLength(40);
            entity.Property(e => e.PartnerPhone).HasMaxLength(10);
            entity.Property(e => e.PartnerWhatsapp).HasMaxLength(11);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.MedPartnerData)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_PartnerData_BranchesData");

            entity.HasOne(d => d.CityCode).WithMany(p => p.MedPartnerData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_Med_PartnerData_CityCode");

            entity.HasOne(d => d.JobData).WithMany(p => p.MedPartnerData)
                .HasForeignKey(d => d.JobDataId)
                .HasConstraintName("FK_Med_PartnerData_JobData");
        });

        modelBuilder.Entity<MedRaysName>(entity =>
        {
            entity.HasKey(e => e.RaysNameId);

            entity.ToTable("Med_RaysName");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.MedRaysNames)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_RaysName_BranchesData");
        });

        modelBuilder.Entity<MedSurgicalService>(entity =>
        {
            entity.HasKey(e => e.SurgicalServicesId);

            entity.ToTable("Med_SurgicalServices");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.SurgicalServicesValue).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.MedSurgicalServices)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Med_SurgicalServices_BranchesData");
        });

        modelBuilder.Entity<MoneyPayment>(entity =>
        {
            entity.ToTable("MoneyPayment");

            entity.Property(e => e.MoneyPaymentId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("MoneyPaymentID");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PaperNumber).HasMaxLength(50);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.MoneyPayments)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MoneyPayment_MoneyPayment");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.MoneyPayments)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_MoneyPayment_CostCenter");

            entity.HasOne(d => d.FromAccountName).WithMany(p => p.MoneyPaymentFromAccountNames)
                .HasForeignKey(d => d.FromAccountNameId)
                .HasConstraintName("FK_MoneyPayment_AccountName");

            entity.HasOne(d => d.FromCash).WithMany(p => p.MoneyPaymentFromCashes)
                .HasForeignKey(d => d.FromCashId)
                .HasConstraintName("FK_MoneyPayment_AccountName2");

            entity.HasOne(d => d.ToAccountName).WithMany(p => p.MoneyPaymentToAccountNames)
                .HasForeignKey(d => d.ToAccountNameId)
                .HasConstraintName("FK_MoneyPayment_AccountName1");
        });

        modelBuilder.Entity<MoneyReceive>(entity =>
        {
            entity.ToTable("MoneyReceive");

            entity.Property(e => e.MoneyReceiveId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("MoneyReceiveID");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PaperNumber).HasMaxLength(50);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.MoneyReceives)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MoneyReceive_CompanyData");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.MoneyReceives)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_MoneyReceive_CostCenter");

            entity.HasOne(d => d.FromAccountName).WithMany(p => p.MoneyReceiveFromAccountNames)
                .HasForeignKey(d => d.FromAccountNameId)
                .HasConstraintName("FK_MoneyReceive_AccountName");

            entity.HasOne(d => d.FromCash).WithMany(p => p.MoneyReceiveFromCashes)
                .HasForeignKey(d => d.FromCashId)
                .HasConstraintName("FK_MoneyReceive_AccountName2");

            entity.HasOne(d => d.ToAccountName).WithMany(p => p.MoneyReceiveToAccountNames)
                .HasForeignKey(d => d.ToAccountNameId)
                .HasConstraintName("FK_MoneyReceive_AccountName1");
        });

        modelBuilder.Entity<Month>(entity =>
        {
            entity.HasKey(e => e.MonthId).HasName("PK_Months");

            entity.ToTable("Month");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.MonthNameL1).HasMaxLength(15);
            entity.Property(e => e.MonthnameL2).HasMaxLength(15);
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<PAdditionAdjustment>(entity =>
        {
            entity.HasKey(e => e.AdditionId);

            entity.ToTable("PAdditionAdjustment");

            entity.Property(e => e.AdditionId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PadditionAdjustments)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PAdditionAdjustment_BranchesData");

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PadditionAdjustments)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PAdditionAdjustment_PItemsHeader");

            entity.HasOne(d => d.StoreData).WithMany(p => p.PadditionAdjustments)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_PAdditionAdjustment_StoreData");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PadditionAdjustments)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PAdditionAdjustment_UnitType");
        });

        modelBuilder.Entity<PaymentMode>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_PaymentType");

            entity.Property(e => e.CodeTax).HasMaxLength(5);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PaymentNameL1).HasMaxLength(50);
            entity.Property(e => e.PaymentNameL2).HasMaxLength(50);
        });

        modelBuilder.Entity<PersistedGrant>(entity =>
        {
            entity.HasKey(e => e.Key);

            entity.Property(e => e.Key).HasMaxLength(200);
            entity.Property(e => e.ClientId)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Data).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.SessionId).HasMaxLength(100);
            entity.Property(e => e.SubjectId).HasMaxLength(200);
            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<PInventoryOrderFooter>(entity =>
        {
            entity.HasKey(e => e.PpurchaseOrderFooterId).HasName("PK_PPurchaseOrderFooter");

            entity.ToTable("PInventoryOrderFooter");

            entity.Property(e => e.PpurchaseOrderFooterId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PPurchaseOrderFooterId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PpurchaseOrderHeaderId).HasColumnName("PPurchaseOrderHeaderId");
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PinventoryOrderFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PPurchaseOrderFooter_PItemsHeader");

            entity.HasOne(d => d.PpurchaseOrderHeader).WithMany(p => p.PinventoryOrderFooters)
                .HasForeignKey(d => d.PpurchaseOrderHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PPurchaseOrderFooter_PPurchaseOrderHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PinventoryOrderFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PPurchaseOrderFooter_UnitType");
        });

        modelBuilder.Entity<PInventoryOrderHeader>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_PPurchaseOrderHeader");

            entity.ToTable("PInventoryOrderHeader");

            entity.Property(e => e.OrderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OrderNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PinventoryOrderHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PPurchaseOrderHeader_BranchesData");

            entity.HasOne(d => d.StoreData).WithMany(p => p.PinventoryOrderHeaders)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_PPurchaseOrderHeader_StoreData");
        });

        modelBuilder.Entity<PItemsBalanceFooter>(entity =>
        {
            entity.HasKey(e => e.ItemsBalanceId);

            entity.ToTable("PItemsBalanceFooter");

            entity.Property(e => e.ItemsBalanceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ItemQuantity).HasDefaultValue(0.0);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsBalanceHeaderId).HasColumnName("PItemsBalanceHeaderId");
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");

            entity.HasOne(d => d.PitemsBalanceHeader).WithMany(p => p.PitemsBalanceFooters)
                .HasForeignKey(d => d.PitemsBalanceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PItemsBalanceFooter_PItemsBalanceHeader");

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PitemsBalanceFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PItemsBalanceFooter_PItemsHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PitemsBalanceFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PItemsBalanceFooter_UnitType");
        });

        modelBuilder.Entity<PItemsBalanceHeader>(entity =>
        {
            entity.HasKey(e => e.BalanceHeaderId);

            entity.ToTable("PItemsBalanceHeader");

            entity.Property(e => e.BalanceHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PitemsBalanceHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PItemsBalanceHeader_BranchesData");

            entity.HasOne(d => d.StoreData).WithMany(p => p.PitemsBalanceHeaders)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_PItemsBalanceHeader_StoreData");
        });

        modelBuilder.Entity<PItemsGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupId);

            entity.ToTable("PItemsGroup");

            entity.Property(e => e.ItemGroupId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ItemCodeTax).HasMaxLength(20);
            entity.Property(e => e.ItemGroupNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemGroupNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.PitemsGroups)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PItemsGroup_BranchesData");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_PItemsGroup_PItemsGroup");
        });

        modelBuilder.Entity<PItemsHeader>(entity =>
        {
            entity.HasKey(e => e.ItemHeaderId);

            entity.ToTable("PItemsHeader");

            entity.Property(e => e.ItemHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsNotActiveTax).HasDefaultValue(false);
            entity.Property(e => e.IsNotActiveTaxDiscount).HasDefaultValue(false);
            entity.Property(e => e.ItemNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsGroupsId).HasColumnName("PItemsGroupsId");

            entity.HasOne(d => d.AccountNameSales).WithMany(p => p.PitemsHeaderAccountNameSales)
                .HasForeignKey(d => d.AccountNameSalesId)
                .HasConstraintName("FK_PItemsHeader_AccountName1");

            entity.HasOne(d => d.AccountsNamePurchas).WithMany(p => p.PitemsHeaderAccountsNamePurchas)
                .HasForeignKey(d => d.AccountsNamePurchasId)
                .HasConstraintName("FK_PItemsHeader_AccountName");

            entity.HasOne(d => d.ItemsType).WithMany(p => p.PitemsHeaders)
                .HasForeignKey(d => d.ItemsTypeId)
                .HasConstraintName("FK_PItemsHeader_ItemsType");

            entity.HasOne(d => d.PitemsGroups).WithMany(p => p.PitemsHeaders)
                .HasForeignKey(d => d.PitemsGroupsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PItemsHeader_PItemsGroup");

            entity.HasOne(d => d.SupplierData).WithMany(p => p.PitemsHeaders)
                .HasForeignKey(d => d.SupplierDataId)
                .HasConstraintName("FK_PItemsHeader_SupplierData");
        });

        modelBuilder.Entity<PItemsStock>(entity =>
        {
            entity.ToTable("PItemsStock");

            entity.Property(e => e.PitemsStockId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PItemsStockId");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.PadditionAdjustmentId).HasColumnName("PAdditionAdjustmentId");
            entity.Property(e => e.PitemsBalanceFooterId).HasColumnName("PItemsBalanceFooterId");
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PrequestReceiptFooterId).HasColumnName("PRequestReceiptFooterId");
            entity.Property(e => e.PrequestReservationFooterId).HasColumnName("PRequestReservationFooterId");
            entity.Property(e => e.PreturnPurchasesFooterId).HasColumnName("PReturnPurchasesFooterId");
            entity.Property(e => e.PreturnReservationFooterId).HasColumnName("PReturnReservationFooterId");
            entity.Property(e => e.PsettlementDiscountId).HasColumnName("PSettlementDiscountId");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PItemsStock_BranchesData");

            entity.HasOne(d => d.PadditionAdjustment).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PadditionAdjustmentId)
                .HasConstraintName("FK_PItemsStock_PAdditionAdjustment");

            entity.HasOne(d => d.PitemsBalanceFooter).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PitemsBalanceFooterId)
                .HasConstraintName("FK_PItemsStock_PItemsBalanceFooter");

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PItemsStock_PItemsHeader");

            entity.HasOne(d => d.PrequestReceiptFooter).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PrequestReceiptFooterId)
                .HasConstraintName("FK_PItemsStock_PRequestReceiptFooter");

            entity.HasOne(d => d.PrequestReservationFooter).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PrequestReservationFooterId)
                .HasConstraintName("FK_PItemsStock_PRequestReservationFooter");

            entity.HasOne(d => d.PreturnPurchasesFooter).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PreturnPurchasesFooterId)
                .HasConstraintName("FK_PItemsStock_PReturnPurchasesFooter");

            entity.HasOne(d => d.PreturnReservationFooter).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PreturnReservationFooterId)
                .HasConstraintName("FK_PItemsStock_PReturnReservationFooter");

            entity.HasOne(d => d.PsettlementDiscount).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.PsettlementDiscountId)
                .HasConstraintName("FK_PItemsStock_PSettlementDiscount");

            entity.HasOne(d => d.StoreData).WithMany(p => p.PitemsStocks)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_PItemsStock_StoreData");
        });

        modelBuilder.Entity<Posmachine>(entity =>
        {
            entity.HasKey(e => e.MachineId);

            entity.ToTable("POSMachine");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.MachineName).HasMaxLength(50);
            entity.Property(e => e.MachineSerial).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.Posmachines)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_MachineName_BranchesData");
        });

        modelBuilder.Entity<PospaymentDaily>(entity =>
        {
            entity.HasKey(e => e.PaymentDailyId).HasName("PK_POSPaymentDaily_1");

            entity.ToTable("POSPaymentDaily");

            entity.Property(e => e.PaymentDailyId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Balance).HasDefaultValue(0.0);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PaymentNo).ValueGeneratedOnAdd();
            entity.Property(e => e.PossalesId).HasColumnName("POSSalesId");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.PospaymentDailies)
                .HasForeignKey(d => d.PaymentModesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POSPaymentDaily_PaymentModes");

            entity.HasOne(d => d.Possales).WithMany(p => p.PospaymentDailies)
                .HasForeignKey(d => d.PossalesId)
                .HasConstraintName("FK_POSPaymentDaily_POSSales");
        });

        modelBuilder.Entity<PosSale>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK_BOSSalesTital");

            entity.ToTable("POSSales");

            entity.Property(e => e.InvoiceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BarcodeInvoice).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.InvoiceNo).ValueGeneratedOnAdd();
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.TaxTotals).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.Possales)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_POSSales_BranchesData");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.Possales)
                .HasForeignKey(d => d.CustomerDataId)
                .HasConstraintName("FK_POSSales_CustomerData");

            entity.HasOne(d => d.PriceType).WithMany(p => p.Possales)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("FK_POSSales_PriceType");
        });

        modelBuilder.Entity<PossalesDetail>(entity =>
        {
            entity.HasKey(e => e.InvoiceDetailsId);

            entity.ToTable("POSSalesDetails");

            entity.Property(e => e.InvoiceDetailsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiscountValue).HasDefaultValue(0.0);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.PossalesId).HasColumnName("POSSalesId");
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.TaxValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ValueAfterDiscount).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.PossalesDetails)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_POSSalesDetails_ItemsHeader");

            entity.HasOne(d => d.Possales).WithMany(p => p.PossalesDetails)
                .HasForeignKey(d => d.PossalesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_POSSalesDetails_POSSales");
        });

        modelBuilder.Entity<PossalesDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountId);

            entity.ToTable("POSSalesDiscount");

            entity.Property(e => e.DiscountId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiscountAmount).HasDefaultValue(0.0);
            entity.Property(e => e.DiscountRate).HasDefaultValue(0.0);
            entity.Property(e => e.PosreturnSalesFooterId).HasColumnName("POSReturnSalesFooterId");
            entity.Property(e => e.PossalesDetailsId).HasColumnName("POSSalesDetailsId");

            entity.HasOne(d => d.PossalesDetails).WithMany(p => p.PossalesDiscounts)
                .HasForeignKey(d => d.PossalesDetailsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_POSSalesDiscount_POSSalesDetails");
        });

        modelBuilder.Entity<Possession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK_BOS_Sessions_1");

            entity.ToTable("POSSessions");

            entity.Property(e => e.SessionId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DateHeureClose)
                .HasDefaultValueSql("((-2))")
                .HasColumnType("datetime");
            entity.Property(e => e.DateHeureOpen)
                .HasDefaultValueSql("((-2))")
                .HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.Possessions)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_POSSessions_BranchesData");

            entity.HasOne(d => d.EmployeesData).WithMany(p => p.Possessions)
                .HasForeignKey(d => d.EmployeesDataId)
                .HasConstraintName("FK_POSSessions_EmployeesData");
        });

        modelBuilder.Entity<PPurchasesInvoiceFooter>(entity =>
        {
            entity.HasKey(e => e.PpurchasesInvoiceFooterId).HasName("PK_PInvoicePurchasesFooter");

            entity.ToTable("PPurchasesInvoiceFooter");

            entity.Property(e => e.PpurchasesInvoiceFooterId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PPurchasesInvoiceFooterId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DiscountValue).HasDefaultValue(0.0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PpurchasesInvoiceHeaderId).HasColumnName("PPurchasesInvoiceHeaderId");
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PpurchasesInvoiceFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PPurchasesInvoiceFooter_PItemsHeader");

            entity.HasOne(d => d.PpurchasesInvoiceHeader).WithMany(p => p.PpurchasesInvoiceFooters)
                .HasForeignKey(d => d.PpurchasesInvoiceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PPurchasesInvoiceFooter_PPurchasesInvoiceHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PpurchasesInvoiceFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PPurchasesInvoiceFooter_UnitType");
        });

        modelBuilder.Entity<PpurchasesInvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.PpurchasesInvoiceHeaderId).HasName("PK_PInvoicePurchasesHeader");

            entity.ToTable("PPurchasesInvoiceHeader");

            entity.Property(e => e.PpurchasesInvoiceHeaderId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PPurchasesInvoiceHeaderId");
            entity.Property(e => e.BarcodeInvoice).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).ValueGeneratedOnAdd();
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PrequestReceiptHeaderid).HasColumnName("PRequestReceiptHeaderid");
            entity.Property(e => e.TotalDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalTaxs).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PpurchasesInvoiceHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PPurchasesInvoiceHeader_BranchesData");

            entity.HasOne(d => d.PrequestReceiptHeader).WithMany(p => p.PpurchasesInvoiceHeaders)
                .HasForeignKey(d => d.PrequestReceiptHeaderid)
                .HasConstraintName("FK_PPurchasesInvoiceHeader_PRequestReceiptHeader");

            entity.HasOne(d => d.SuppliersData).WithMany(p => p.PpurchasesInvoiceHeaders)
                .HasForeignKey(d => d.SuppliersDataid)
                .HasConstraintName("FK_PPurchasesInvoiceHeader_SupplierData");
        });

        modelBuilder.Entity<PRequestReceiptFooter>(entity =>
        {
            entity.ToTable("PRequestReceiptFooter");

            entity.Property(e => e.PrequestReceiptFooterId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PRequestReceiptFooterId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PrequestReceiptHeaderId).HasColumnName("PRequestReceiptHeaderId");
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PrequestReceiptFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PRequestReceiptFooter_PItemsHeader");

            entity.HasOne(d => d.PrequestReceiptHeader).WithMany(p => p.PrequestReceiptFooters)
                .HasForeignKey(d => d.PrequestReceiptHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PRequestReceiptFooter_PRequestReceiptHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PrequestReceiptFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PRequestReceiptFooter_UnitType");
        });

        modelBuilder.Entity<PrequestReceiptHeader>(entity =>
        {
            entity.ToTable("PRequestReceiptHeader");

            entity.Property(e => e.PrequestReceiptHeaderId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PRequestReceiptHeaderId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PpurchaseOrderHeaderId).HasColumnName("PPurchaseOrderHeaderId");
            entity.Property(e => e.RequestReceiptNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PrequestReceiptHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PRequestReceiptHeader_BranchesData");

            entity.HasOne(d => d.PpurchaseOrderHeader).WithMany(p => p.PrequestReceiptHeaders)
                .HasForeignKey(d => d.PpurchaseOrderHeaderId)
                .HasConstraintName("FK_PRequestReceiptHeader_PPurchaseOrderHeader");

            entity.HasOne(d => d.StoreData).WithMany(p => p.PrequestReceiptHeaders)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_PRequestReceiptHeader_StoreData");
        });

        modelBuilder.Entity<PRequestReservationFooter>(entity =>
        {
            entity.ToTable("PRequestReservationFooter");

            entity.Property(e => e.PrequestReservationFooterId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PRequestReservationFooterId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PrequestReservationHeaderId).HasColumnName("PRequestReservationHeaderId");
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PrequestReservationFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PRequestReservationFooter_PItemsHeader");

            entity.HasOne(d => d.PrequestReservationHeader).WithMany(p => p.PrequestReservationFooters)
                .HasForeignKey(d => d.PrequestReservationHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PRequestReservationFooter_PRequestReservationHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PrequestReservationFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PRequestReservationFooter_TypeUnit");
        });

        modelBuilder.Entity<PrequestReservationHeader>(entity =>
        {
            entity.HasKey(e => e.PrequestReceiptHeaderId);

            entity.ToTable("PRequestReservationHeader");

            entity.Property(e => e.PrequestReceiptHeaderId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PRequestReceiptHeaderId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReceiptNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PrequestReservationHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PRequestReservationHeader_BranchesData");
        });

        modelBuilder.Entity<PReturnPurchasesFooter>(entity =>
        {
            entity.ToTable("PReturnPurchasesFooter");

            entity.Property(e => e.PreturnPurchasesFooterId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PReturnPurchasesFooterId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PreturnPurchasesHeaderId).HasColumnName("PReturnPurchasesHeaderId");
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PreturnPurchasesFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PReturnPurchasesFooter_PItemsHeader");

            entity.HasOne(d => d.PreturnPurchasesHeader).WithMany(p => p.PreturnPurchasesFooters)
                .HasForeignKey(d => d.PreturnPurchasesHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PReturnPurchasesFooter_PReturnPurchasesHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PreturnPurchasesFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PReturnPurchasesFooter_UnitType");
        });

        modelBuilder.Entity<PreturnPurchasesHeader>(entity =>
        {
            entity.ToTable("PReturnPurchasesHeader");

            entity.Property(e => e.PreturnPurchasesHeaderId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PReturnPurchasesHeaderId");
            entity.Property(e => e.BarcodeInvoice).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.PinvoicePurchasesHeaderId).HasColumnName("PInvoicePurchasesHeaderId");
            entity.Property(e => e.ReturnNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalAfterDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalTaxs).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PreturnPurchasesHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PReturnPurchasesHeader_BranchesData");

            entity.HasOne(d => d.DocumentsModes).WithMany(p => p.PreturnPurchasesHeaders)
                .HasForeignKey(d => d.DocumentsModesId)
                .HasConstraintName("FK_PReturnPurchasesHeader_DocumentsModes");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.PreturnPurchasesHeaders)
                .HasForeignKey(d => d.PaymentModesId)
                .HasConstraintName("FK_PReturnPurchasesHeader_PaymentModes");

            entity.HasOne(d => d.PinvoicePurchasesHeader).WithMany(p => p.PreturnPurchasesHeaders)
                .HasForeignKey(d => d.PinvoicePurchasesHeaderId)
                .HasConstraintName("FK_PReturnPurchasesHeader_PPurchasesInvoiceHeader");

            entity.HasOne(d => d.SuppliersData).WithMany(p => p.PreturnPurchasesHeaders)
                .HasForeignKey(d => d.SuppliersDataId)
                .HasConstraintName("FK_PReturnPurchasesHeader_SupplierData");
        });

        modelBuilder.Entity<PReturnReservationFooter>(entity =>
        {
            entity.ToTable("PReturnReservationFooter");

            entity.Property(e => e.PreturnReservationFooterId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PReturnReservationFooterId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PitemsHeaderId).HasColumnName("PItemsHeaderId");
            entity.Property(e => e.PreturnReservationHeaderId).HasColumnName("PReturnReservationHeaderId");
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.PitemsHeader).WithMany(p => p.PreturnReservationFooters)
                .HasForeignKey(d => d.PitemsHeaderId)
                .HasConstraintName("FK_PReturnReservationFooter_PItemsHeader");

            entity.HasOne(d => d.PreturnReservationHeader).WithMany(p => p.PreturnReservationFooters)
                .HasForeignKey(d => d.PreturnReservationHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PReturnReservationFooter_PReturnReservationHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PreturnReservationFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PReturnReservationFooter_TypeUnit");
        });

        modelBuilder.Entity<PreturnReservationHeader>(entity =>
        {
            entity.HasKey(e => e.PreturnReceiptHeaderId);

            entity.ToTable("PReturnReservationHeader");

            entity.Property(e => e.PreturnReceiptHeaderId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("PReturnReceiptHeaderId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReceiptNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PreturnReservationHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PReturnReservationHeader_BranchesData");
        });

        modelBuilder.Entity<PriceType>(entity =>
        {
            entity.HasKey(e => e.PriceId).HasName("PK_ItemsPrice");

            entity.ToTable("PriceType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.PriceNameL1).HasMaxLength(50);
            entity.Property(e => e.PriceNameL2).HasMaxLength(50);
        });

        modelBuilder.Entity<ProgramOption>(entity =>
        {
            entity.ToTable("ProgramOption");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.ApplicationMenu).WithMany(p => p.ProgramOptions)
                .HasForeignKey(d => d.ApplicationMenuId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgramOption_ApplicationMenu");
        });

        modelBuilder.Entity<PsettlementDiscount>(entity =>
        {
            entity.HasKey(e => e.SettlementId);

            entity.ToTable("PSettlementDiscount");

            entity.Property(e => e.SettlementId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PsettlementDiscounts)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PSettlementDiscount_BranchesData");

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.PsettlementDiscounts)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_PSettlementDiscount_ItemsHeader");

            entity.HasOne(d => d.StoreData).WithMany(p => p.PsettlementDiscounts)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_PSettlementDiscount_StoreData");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PsettlementDiscounts)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PSettlementDiscount_UnitType");
        });

        modelBuilder.Entity<PurchasesInvoiceDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountInvoiceId).HasName("PK_DiscountInvoicePurchases");

            entity.ToTable("PurchasesInvoiceDiscount");

            entity.Property(e => e.DiscountInvoiceId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DiscountType).WithMany(p => p.PurchasesInvoiceDiscounts)
                .HasForeignKey(d => d.DiscountTypeId)
                .HasConstraintName("FK_DiscountInvoicePurchases_DiscountType");

            entity.HasOne(d => d.PurchasesInvoiceFooter).WithMany(p => p.PurchasesInvoiceDiscounts)
                .HasForeignKey(d => d.PurchasesInvoiceFooterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DiscountInvoicePurchases_InvoicePurchasesFooter");

            entity.HasOne(d => d.ReturnPurchasesFooter).WithMany(p => p.PurchasesInvoiceDiscounts)
                .HasForeignKey(d => d.ReturnPurchasesFooterId)
                .HasConstraintName("FK_DiscountInvoicePurchases_ReturnPurchasesFooter");
        });

        modelBuilder.Entity<PurchasesInvoiceFooter>(entity =>
        {
            entity.HasKey(e => e.PurchasesInvoiceFooterId).HasName("PK_InvoicePurchasesFooter");

            entity.ToTable("PurchasesInvoiceFooter");

            entity.Property(e => e.PurchasesInvoiceFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DiscountValue).HasDefaultValue(0.0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.TaxValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ValueAfterDiscount).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.PurchasesInvoiceFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_InvoicePurchasesFooter_ItemsHeader");

            entity.HasOne(d => d.PurchasesInvoiceHeader).WithMany(p => p.PurchasesInvoiceFooters)
                .HasForeignKey(d => d.PurchasesInvoiceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InvoicePurchasesFooter_InvoicePurchasesHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PurchasesInvoiceFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_InvoicePurchasesFooter_UnitType");
        });

        modelBuilder.Entity<PurchasesInvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.PurchasesInvoiceHeaderId).HasName("PK_InvoicePurchasesHeader");

            entity.ToTable("PurchasesInvoiceHeader");

            entity.Property(e => e.PurchasesInvoiceHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BarcodeInvoice).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).ValueGeneratedOnAdd();
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TotalAfterDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalTaxs).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PurchasesInvoiceHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InvoicePurchasesHeader_BranchesData");

            entity.HasOne(d => d.DocumentsModes).WithMany(p => p.PurchasesInvoiceHeaders)
                .HasForeignKey(d => d.DocumentsModesId)
                .HasConstraintName("FK_InvoicePurchasesHeader_DocumentsModes");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.PurchasesInvoiceHeaders)
                .HasForeignKey(d => d.PaymentModesId)
                .HasConstraintName("FK_PurchasesInvoiceHeader_PaymentModes");

            entity.HasOne(d => d.RequestReceiptHeader).WithMany(p => p.PurchasesInvoiceHeaders)
                .HasForeignKey(d => d.RequestReceiptHeaderid)
                .HasConstraintName("FK_PurchasesInvoiceHeader_RequestReceiptHeader");

            entity.HasOne(d => d.SuppliersData).WithMany(p => p.PurchasesInvoiceHeaders)
                .HasForeignKey(d => d.SuppliersDataid)
                .HasConstraintName("FK_InvoicePurchasesHeader_SupplierData");
        });

        modelBuilder.Entity<PurchasesOrderFooter>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("PurchasesOrderFooter");

            entity.Property(e => e.OrderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.PurchasesOrderFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_PurchasesOrderFooter_ItemsHeader");

            entity.HasOne(d => d.PurchaseOrderHeader).WithMany(p => p.PurchasesOrderFooters)
                .HasForeignKey(d => d.PurchaseOrderHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PurchasesOrderFooter_PurchasesOrderHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.PurchasesOrderFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_PurchasesOrderFooter_UnitType");
        });

        modelBuilder.Entity<PurchasesOrderHeader>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_PurchasesOrderHeader_1");

            entity.ToTable("PurchasesOrderHeader");

            entity.Property(e => e.OrderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OrderNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.PurchasesOrderHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PurchasesOrderHeader_BranchesData");

            entity.HasOne(d => d.SupplierData).WithMany(p => p.PurchasesOrderHeaders)
                .HasForeignKey(d => d.SupplierDataId)
                .HasConstraintName("FK_PurchasesOrderHeader_SupplierData");
        });

        modelBuilder.Entity<PurchasesTaxInvoice>(entity =>
        {
            entity.HasKey(e => e.TaxInvoiceId).HasName("PK_TaxInvoicePurchases");

            entity.ToTable("PurchasesTaxInvoice");

            entity.Property(e => e.TaxInvoiceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TaxAmount).HasDefaultValue(0.0);

            entity.HasOne(d => d.InvoicePurchasesFooter).WithMany(p => p.PurchasesTaxInvoices)
                .HasForeignKey(d => d.InvoicePurchasesFooterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PurchasesTaxInvoice_PurchasesInvoiceFooter");

            entity.HasOne(d => d.ReturnPurchasesFooter).WithMany(p => p.PurchasesTaxInvoices)
                .HasForeignKey(d => d.ReturnPurchasesFooterId)
                .HasConstraintName("FK_PurchasesTaxInvoice_PurchasesReturnFooter");

            entity.HasOne(d => d.TaxableType).WithMany(p => p.PurchasesTaxInvoices)
                .HasForeignKey(d => d.TaxableTypeId)
                .HasConstraintName("FK_PurchasesTaxInvoice_TaxableType");
        });

        modelBuilder.Entity<RecruitmentDatum>(entity =>
        {
            entity.HasKey(e => e.RecruitmentId).HasName("PK_Recruitment");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            entity.Property(e => e.RecruitmentNameL1).HasMaxLength(30);
            entity.Property(e => e.RecruitmentNameL2).HasMaxLength(30);
        });

        modelBuilder.Entity<ReportViewWorkPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReportViewWorkPlan");

            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.Atmaddress)
                .HasMaxLength(50)
                .HasColumnName("ATMAddress");
            entity.Property(e => e.Atmlocation).HasColumnName("ATMLocation");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.BankAtmid).HasColumnName("BankATMId");
            entity.Property(e => e.BanknameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<ReportsName>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.ToTable("ReportsName");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReportNameL1).HasMaxLength(50);
            entity.Property(e => e.ReportNameL2).HasMaxLength(50);

            entity.HasOne(d => d.ApplicationMenu).WithMany(p => p.ReportsNames)
                .HasForeignKey(d => d.ApplicationMenuId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReportsName_ApplicationMenu");
        });

        modelBuilder.Entity<RequestReceiptFooter>(entity =>
        {
            entity.ToTable("RequestReceiptFooter");

            entity.Property(e => e.RequestReceiptFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.RequestReceiptFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_RequestReceiptFooter_ItemsHeader");

            entity.HasOne(d => d.RequestReceiptHeader).WithMany(p => p.RequestReceiptFooters)
                .HasForeignKey(d => d.RequestReceiptHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RequestReceiptFooter_RequestReceiptHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.RequestReceiptFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_RequestReceiptFooter_UnitType");
        });

        modelBuilder.Entity<RequestReceiptHeader>(entity =>
        {
            entity.ToTable("RequestReceiptHeader");

            entity.Property(e => e.RequestReceiptHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.RequestReceiptNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RequestReceiptHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RequestReceiptHeader_BranchesData");

            entity.HasOne(d => d.PurchaseOrderHeader).WithMany(p => p.RequestReceiptHeaders)
                .HasForeignKey(d => d.PurchaseOrderHeaderId)
                .HasConstraintName("FK_RequestReceiptHeader_InventoryOrderHeader");

            entity.HasOne(d => d.StoreData).WithMany(p => p.RequestReceiptHeaders)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_RequestReceiptHeader_StoreData");
        });

        modelBuilder.Entity<RequestReservationFooter>(entity =>
        {
            entity.ToTable("RequestReservationFooter");

            entity.Property(e => e.RequestReservationFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.RequestReservationFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_RequestReservationFooter_ItemsHeader");

            entity.HasOne(d => d.RequestReservationHeader).WithMany(p => p.RequestReservationFooters)
                .HasForeignKey(d => d.RequestReservationHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RequestReservationFooter_RequestReservationHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.RequestReservationFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_RequestReservationFooter_TypeUnit");
        });

        modelBuilder.Entity<RequestReservationHeader>(entity =>
        {
            entity.HasKey(e => e.RequestReceiptHeaderId);

            entity.ToTable("RequestReservationHeader");

            entity.Property(e => e.RequestReceiptHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReceiptNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RequestReservationHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RequestReservationHeader_BranchesData");
        });

        modelBuilder.Entity<ReservationDebit>(entity =>
        {
            entity.HasKey(e => e.ReservationId);

            entity.ToTable("ReservationDebit");

            entity.Property(e => e.ReservationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReservationUd).ValueGeneratedOnAdd();
            entity.Property(e => e.ReservationValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.ReservationDebits)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReservationDebit_CompanyData");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.ReservationDebits)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_ReservationDebit_CostCenter");

            entity.HasOne(d => d.ReservationStatus).WithMany(p => p.ReservationDebits)
                .HasForeignKey(d => d.ReservationStatusId)
                .HasConstraintName("FK_ReservationDebit_ReservationStatus");
        });

        modelBuilder.Entity<ReservationStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("ReservationStatus");

            entity.Property(e => e.StatusId).ValueGeneratedNever();
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.StatusNameL1)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.StatusNameL2)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<ReturnPurchasesFooter>(entity =>
        {
            entity.ToTable("ReturnPurchasesFooter");

            entity.Property(e => e.ReturnPurchasesFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ReturnPurchasesFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_ReturnPurchasesFooter_ItemsHeader");

            entity.HasOne(d => d.ReturnPurchasesHeader).WithMany(p => p.ReturnPurchasesFooters)
                .HasForeignKey(d => d.ReturnPurchasesHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReturnPurchasesFooter_ReturnPurchasesHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.ReturnPurchasesFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_ReturnPurchasesFooter_UnitType");
        });

        modelBuilder.Entity<ReturnPurchasesHeader>(entity =>
        {
            entity.ToTable("ReturnPurchasesHeader");

            entity.Property(e => e.ReturnPurchasesHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BarcodeInvoice).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.ReturnNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalTaxs).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.ReturnPurchasesHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReturnPurchasesHeader_BranchesData");

            entity.HasOne(d => d.DocumentsModes).WithMany(p => p.ReturnPurchasesHeaders)
                .HasForeignKey(d => d.DocumentsModesId)
                .HasConstraintName("FK_ReturnPurchasesHeader_DocumentsModes");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.ReturnPurchasesHeaders)
                .HasForeignKey(d => d.PaymentModesId)
                .HasConstraintName("FK_ReturnPurchasesHeader_PaymentModes");

            entity.HasOne(d => d.PurchasesInvoiceHeader).WithMany(p => p.ReturnPurchasesHeaders)
                .HasForeignKey(d => d.PurchasesInvoiceHeaderId)
                .HasConstraintName("FK_ReturnPurchasesHeader_PurchasesInvoiceHeader");

            entity.HasOne(d => d.SuppliersData).WithMany(p => p.ReturnPurchasesHeaders)
                .HasForeignKey(d => d.SuppliersDataId)
                .HasConstraintName("FK_ReturnPurchasesHeader_SupplierData");
        });

        modelBuilder.Entity<ReturnSalesFooter>(entity =>
        {
            entity.ToTable("ReturnSalesFooter");

            entity.Property(e => e.ReturnSalesFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.ReturnSalesFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_ReturnSalesFooter_ItemsHeader");

            entity.HasOne(d => d.ReturnSalesHeader).WithMany(p => p.ReturnSalesFooters)
                .HasForeignKey(d => d.ReturnSalesHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReturnSalesFooter_ReturnSalesHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.ReturnSalesFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_ReturnSalesFooter_UnitType");
        });

        modelBuilder.Entity<ReturnSalesHeader>(entity =>
        {
            entity.ToTable("ReturnSalesHeader");

            entity.Property(e => e.ReturnSalesHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BarcodeReturn).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReturnNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TaxTotals).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.ReturnSalesHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReturnSalesHeader_BranchesData");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.ReturnSalesHeaders)
                .HasForeignKey(d => d.CustomerDataId)
                .HasConstraintName("FK_ReturnSalesHeader_CustomerData");

            entity.HasOne(d => d.DocumentsModes).WithMany(p => p.ReturnSalesHeaders)
                .HasForeignKey(d => d.DocumentsModesId)
                .HasConstraintName("FK_ReturnSalesHeader_DocumentsModes");

            entity.HasOne(d => d.InvoiceSalesHeader).WithMany(p => p.ReturnSalesHeaders)
                .HasForeignKey(d => d.InvoiceSalesHeaderId)
                .HasConstraintName("FK_ReturnSalesHeader_SalesInvoiceHeader");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.ReturnSalesHeaders)
                .HasForeignKey(d => d.PaymentModesId)
                .HasConstraintName("FK_ReturnSalesHeader_PaymentModes");

            entity.HasOne(d => d.PriceType).WithMany(p => p.ReturnSalesHeaders)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("FK_ReturnSalesHeader_PriceType");
        });

        modelBuilder.Entity<RntActivity>(entity =>
        {
            entity.HasKey(e => e.ActivitiesId).HasName("PK_RNT_Activities_1");

            entity.ToTable("RNT_Activities");

            entity.Property(e => e.ActivityNameL1).HasMaxLength(255);
            entity.Property(e => e.ActivityNameL2).HasMaxLength(255);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntActivities)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_Activities_BranchesData");
        });

        modelBuilder.Entity<RntContractsD>(entity =>
        {
            entity.HasKey(e => e.ContractId);

            entity.ToTable("RNT_ContractsD");

            entity.Property(e => e.ContractId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ContractsHid).HasColumnName("ContractsHId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.ContractsH).WithMany(p => p.RntContractsDs)
                .HasForeignKey(d => d.ContractsHid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_ContractsD_RNT_ContractsH");

            entity.HasOne(d => d.Floors).WithMany(p => p.RntContractsDs)
                .HasForeignKey(d => d.FloorsId)
                .HasConstraintName("FK_RNT_ContractsD_RNT_Floors");

            entity.HasOne(d => d.UnitType).WithMany(p => p.RntContractsDs)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_RNT_ContractsD_UnitType");
        });

        modelBuilder.Entity<RntContractsH>(entity =>
        {
            entity.HasKey(e => e.ContractId);

            entity.ToTable("RNT_ContractsH");

            entity.Property(e => e.ContractId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ContractCode).ValueGeneratedOnAdd();
            entity.Property(e => e.ContractEndDate).HasColumnType("datetime");
            entity.Property(e => e.ContractStartDate).HasColumnType("datetime");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IncreasingDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.Activities).WithMany(p => p.RntContractsHes)
                .HasForeignKey(d => d.ActivitiesId)
                .HasConstraintName("FK_RNT_ContractsH_RNT_Activities");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntContractsHes)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_RNT_ContractsH_BranchesData");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.RntContractsHes)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_ContractsH_CustomerData");
        });

        modelBuilder.Entity<RntCustomerPercentD>(entity =>
        {
            entity.HasKey(e => e.PercentId);

            entity.ToTable("RNT_CustomerPercentD");

            entity.Property(e => e.PercentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CustomerPercent).WithMany(p => p.RntCustomerPercentDs)
                .HasForeignKey(d => d.CustomerPercentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_CustomerPercentD_RNT_CustomerPercentH");
        });

        modelBuilder.Entity<RntCustomerPercentH>(entity =>
        {
            entity.HasKey(e => e.PercentId);

            entity.ToTable("RNT_CustomerPercentH");

            entity.Property(e => e.PercentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DistributeDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntCustomerPercentHs)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_RNT_CustomerPercentH_BranchesData");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.RntCustomerPercentHs)
                .HasForeignKey(d => d.CustomerDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_CustomerPercentH_CustomerData");
        });

        modelBuilder.Entity<RntExpense>(entity =>
        {
            entity.HasKey(e => e.ExpenseId);

            entity.ToTable("RNT_Expenses");

            entity.Property(e => e.ExpenseId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ExpenseCodeId).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpenseDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntExpenses)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_Expenses_BranchesData");

            entity.HasOne(d => d.ExpenseType).WithMany(p => p.RntExpenses)
                .HasForeignKey(d => d.ExpenseTypeId)
                .HasConstraintName("FK_RNT_Expenses_RNT_ExpenseTypes");
        });

        modelBuilder.Entity<RntExpenseType>(entity =>
        {
            entity.HasKey(e => e.ExpenseId);

            entity.ToTable("RNT_ExpenseTypes");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ExpenseNameL1).HasMaxLength(255);
            entity.Property(e => e.ExpenseNameL2).HasMaxLength(255);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntExpenseTypes)
                .HasForeignKey(d => d.BranchesDataId)
                .HasConstraintName("FK_RNT_ExpenseTypes_BranchesData");
        });

        modelBuilder.Entity<RntFloor>(entity =>
        {
            entity.HasKey(e => e.FloorId);

            entity.ToTable("RNT_Floors");

            entity.Property(e => e.FloorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FloorsCode).ValueGeneratedOnAdd();
            entity.Property(e => e.FloorsNameL1).HasMaxLength(255);
            entity.Property(e => e.FloorsNameL2).HasMaxLength(255);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntFloors)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_Floors_BranchesData");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_RNT_Floors_RNT_Floors");
        });

        modelBuilder.Entity<RntReceiptsD>(entity =>
        {
            entity.HasKey(e => e.ReceiptId).HasName("PK_ReceiptD");

            entity.ToTable("RNT_ReceiptsD");

            entity.Property(e => e.ReceiptId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.ReciptNo).HasMaxLength(255);

            entity.HasOne(d => d.ReceiptHNavigation).WithMany(p => p.RntReceiptsDs)
                .HasForeignKey(d => d.ReceiptH)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReceiptD_RNT_ReceiptsH");
        });

        modelBuilder.Entity<RntReceiptsHeader>(entity =>
        {
            entity.HasKey(e => e.ReceiptId);

            entity.ToTable("RNT_ReceiptsH");

            entity.Property(e => e.ReceiptId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ReceiptCode).ValueGeneratedOnAdd();
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.RntReceiptsHes)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RNT_ReceiptsH_BranchesData");

            entity.HasOne(d => d.Contracts).WithMany(p => p.RntReceiptsHes)
                .HasForeignKey(d => d.ContractsId)
                .HasConstraintName("FK_RNT_ReceiptsH_RNT_ContractsH");

            entity.HasOne(d => d.CurrencyData).WithMany(p => p.RntReceiptsHes)
                .HasForeignKey(d => d.CurrencyDataId)
                .HasConstraintName("FK_RNT_ReceiptsH_CurrencyData");
        });

        modelBuilder.Entity<SalesInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesInvoice");

            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.DateValidity).HasMaxLength(50);
            entity.Property(e => e.DeliveryNameL1).HasMaxLength(50);
            entity.Property(e => e.PaymentNameL1).HasMaxLength(50);
            entity.Property(e => e.PriceNameL1).HasMaxLength(50);
            entity.Property(e => e.TaxNameL1).HasMaxLength(50);
            entity.Property(e => e.UnitNameL1).HasMaxLength(70);
        });

        modelBuilder.Entity<SalesInvoiceDelivery>(entity =>
        {
            entity.HasKey(e => e.DeliveryId).HasName("PK_Delivery");

            entity.ToTable("SalesInvoiceDelivery");

            entity.Property(e => e.DeliveryId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Approach).HasMaxLength(50);
            entity.Property(e => e.CountryOfOriginId).HasMaxLength(50);
            entity.Property(e => e.DateValidity).HasMaxLength(50);
            entity.Property(e => e.DeliveryValue).HasDefaultValue(0.0);
            entity.Property(e => e.ExportPort).HasMaxLength(50);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NetWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Terms).HasMaxLength(50);

            entity.HasOne(d => d.DeliveryModes).WithMany(p => p.SalesInvoiceDeliveries)
                .HasForeignKey(d => d.DeliveryModesId)
                .HasConstraintName("FK_InvoiceSalesDelivery_DeliveryModes");

            entity.HasOne(d => d.InvoiceSalesHeader).WithMany(p => p.SalesInvoiceDeliveries)
                .HasForeignKey(d => d.InvoiceSalesHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesInvoiceDelivery_SalesInvoiceHeader");
        });

        modelBuilder.Entity<SalesInvoiceDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountInvoiceId).HasName("PK_DiscountInvoice");

            entity.ToTable("SalesInvoiceDiscount");

            entity.Property(e => e.DiscountInvoiceId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DiscountInvoice).WithOne(p => p.SalesInvoiceDiscount)
                .HasForeignKey<SalesInvoiceDiscount>(d => d.DiscountInvoiceId)
                .HasConstraintName("FK_SalesInvoiceDiscount_SalesInvoiceFooter");

            entity.HasOne(d => d.DiscountType).WithMany(p => p.SalesInvoiceDiscounts)
                .HasForeignKey(d => d.DiscountTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DiscountInvoice_DiscountType");

            entity.HasOne(d => d.ReturnSalesFooter).WithMany(p => p.SalesInvoiceDiscounts)
                .HasForeignKey(d => d.ReturnSalesFooterId)
                .HasConstraintName("FK_DiscountInvoiceSales_ReturnSalesFooter");
        });

        modelBuilder.Entity<SalesInvoiceFooter>(entity =>
        {
            entity.HasKey(e => e.SalesInvoiceFooterId).HasName("PK_InvoiceSalesFooter");

            entity.ToTable("SalesInvoiceFooter");

            entity.Property(e => e.SalesInvoiceFooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.DiscountValue).HasDefaultValue(0.0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ItemValue).HasDefaultValue(0.0);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.TaxValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);
            entity.Property(e => e.ValueAfterDiscount).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.SalesInvoiceFooters)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_SalesInvoiceFooter_ItemsHeader");

            entity.HasOne(d => d.SalesInvoiceHeader).WithMany(p => p.SalesInvoiceFooters)
                .HasForeignKey(d => d.SalesInvoiceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesInvoiceFooter_SalesInvoiceHeader");

            entity.HasOne(d => d.UnitType).WithMany(p => p.SalesInvoiceFooters)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_SalesInvoiceFooter_UnitType");
        });

        modelBuilder.Entity<SalesInvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.InvoiceSalesHeaderId).HasName("PK_InvoiceSalesHeader");

            entity.ToTable("SalesInvoiceHeader");

            entity.Property(e => e.InvoiceSalesHeaderId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BarcodeInvoice).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.InvoiceNo).ValueGeneratedOnAdd();
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsPosted).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NetValue).HasDefaultValue(0.0);
            entity.Property(e => e.TaxTotals).HasDefaultValue(0.0);
            entity.Property(e => e.TotalAfterDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalDiscounts).HasDefaultValue(0.0);
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.SalesInvoiceHeaders)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesInvoiceHeader_BranchesData");

            entity.HasOne(d => d.CustomerData).WithMany(p => p.SalesInvoiceHeaders)
                .HasForeignKey(d => d.CustomerDataId)
                .HasConstraintName("FK_SalesInvoiceHeader_CustomerData");

            entity.HasOne(d => d.DocumentsModes).WithMany(p => p.SalesInvoiceHeaders)
                .HasForeignKey(d => d.DocumentsModesId)
                .HasConstraintName("FK_SalesInvoiceHeader_DocumentsModes");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.SalesInvoiceHeaders)
                .HasForeignKey(d => d.PaymentModesId)
                .HasConstraintName("FK_SalesInvoiceHeader_PaymentModes");

            entity.HasOne(d => d.PriceType).WithMany(p => p.SalesInvoiceHeaders)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("FK_SalesInvoiceHeader_PriceType");

            entity.HasOne(d => d.RequestReservationHeader).WithMany(p => p.SalesInvoiceHeaders)
                .HasForeignKey(d => d.RequestReservationHeaderId)
                .HasConstraintName("FK_SalesInvoiceHeader_RequestReservationHeader");
        });

        modelBuilder.Entity<SalesInvoicePayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_PaymentInvoice");

            entity.ToTable("SalesInvoicePayment");

            entity.Property(e => e.PaymentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Balance).HasDefaultValue(0.0);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.Credit).HasDefaultValue(0.0);
            entity.Property(e => e.Debit).HasDefaultValue(0.0);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BankCode).WithMany(p => p.SalesInvoicePayments)
                .HasForeignKey(d => d.BankCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesInvoicePayment_BankCode");

            entity.HasOne(d => d.PaymentModes).WithMany(p => p.SalesInvoicePayments)
                .HasForeignKey(d => d.PaymentModesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesInvoicePayment_PaymentModes");

            entity.HasOne(d => d.SalesInvoiceHeader).WithMany(p => p.SalesInvoicePayments)
                .HasForeignKey(d => d.SalesInvoiceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesInvoicePayment_SalesInvoiceHeader");
        });

        modelBuilder.Entity<SalesInvoicesDelivery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesInvoicesDelivery");

            entity.Property(e => e.CustomerMobil).HasMaxLength(40);
            entity.Property(e => e.DateValidity).HasMaxLength(50);
            entity.Property(e => e.DeliveryNameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesTaxInvoiceF>(entity =>
        {
            entity.HasKey(e => e.TaxInvoiceId).HasName("PK_TaxInvoice");

            entity.ToTable("SalesTaxInvoiceF");

            entity.Property(e => e.TaxInvoiceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TaxAmount).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.SalesTaxInvoiceFs)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_SalesTaxInvoiceF_ItemsHeader");

            entity.HasOne(d => d.ReturnSalesFooter).WithMany(p => p.SalesTaxInvoiceFs)
                .HasForeignKey(d => d.ReturnSalesFooterId)
                .HasConstraintName("FK_SalesTaxInvoiceF_ReturnSalesFooter");

            entity.HasOne(d => d.SalesInvoiceFooter).WithMany(p => p.SalesTaxInvoiceFs)
                .HasForeignKey(d => d.SalesInvoiceFooterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesTaxInvoiceF_SalesInvoiceFooter");

            entity.HasOne(d => d.TaxableType).WithMany(p => p.SalesTaxInvoiceFs)
                .HasForeignKey(d => d.TaxableTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesTaxInvoiceF_TaxableType");
        });

        modelBuilder.Entity<SalesTaxInvoiceH>(entity =>
        {
            entity.HasKey(e => e.TaxInvoiceId);

            entity.ToTable("SalesTaxInvoiceH");

            entity.Property(e => e.TaxInvoiceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TaxAmount).HasDefaultValue(0.0);

            entity.HasOne(d => d.ReturnSalesHeader).WithMany(p => p.SalesTaxInvoiceHs)
                .HasForeignKey(d => d.ReturnSalesHeaderId)
                .HasConstraintName("FK_SalesTaxInvoiceH_ReturnSalesHeader");

            entity.HasOne(d => d.SalesInvoiceHeader).WithMany(p => p.SalesTaxInvoiceHs)
                .HasForeignKey(d => d.SalesInvoiceHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesTaxInvoiceH_SalesInvoiceHeader");

            entity.HasOne(d => d.TaxableType).WithMany(p => p.SalesTaxInvoiceHs)
                .HasForeignKey(d => d.TaxableTypeId)
                .HasConstraintName("FK_SalesTaxInvoiceH_TaxableType");
        });

        modelBuilder.Entity<ServerType>(entity =>
        {
            entity.HasKey(e => e.ServerId);

            entity.ToTable("ServerType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.ServerNameL1).HasMaxLength(20);
            entity.Property(e => e.ServerNameL2).HasMaxLength(20);
        });

        modelBuilder.Entity<SettlementDiscount>(entity =>
        {
            entity.HasKey(e => e.SettlementId);

            entity.ToTable("SettlementDiscount");

            entity.Property(e => e.SettlementId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.SettlementNo).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalValue).HasDefaultValue(0.0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);

            entity.HasOne(d => d.BranchesData).WithMany(p => p.SettlementDiscounts)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SettlementDiscount_BranchesData");

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.SettlementDiscounts)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_SettlementDiscount_ItemsHeader");

            entity.HasOne(d => d.StoreData).WithMany(p => p.SettlementDiscounts)
                .HasForeignKey(d => d.StoreDataId)
                .HasConstraintName("FK_SettlementDiscount_StoreData");

            entity.HasOne(d => d.UnitType).WithMany(p => p.SettlementDiscounts)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_SettlementDiscount_UnitType");
        });

        modelBuilder.Entity<SizeType>(entity =>
        {
            entity.HasKey(e => e.SizeId).HasName("PK_ItemsSize");

            entity.ToTable("SizeType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.SizenameL1).HasMaxLength(20);
            entity.Property(e => e.SizenameL2).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialDatum>(entity =>
        {
            entity.HasKey(e => e.SocialDataId).HasName("PK_Social");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.SocialNameL1).HasMaxLength(50);
            entity.Property(e => e.SocialNameL2).HasMaxLength(50);
        });

        modelBuilder.Entity<StatusDatum>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            entity.Property(e => e.StatusNameL1).HasMaxLength(20);
            entity.Property(e => e.StatusNameL2).HasMaxLength(20);
        });

        modelBuilder.Entity<StokSalesInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StokSalesInvoice");

            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.UnitNameL1).HasMaxLength(70);
            entity.Property(e => e.UnitNameL2).HasMaxLength(70);
        });

        modelBuilder.Entity<StoreData>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK_StoresData");

            entity.Property(e => e.StoreId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.StoreAddress).HasMaxLength(100);
            entity.Property(e => e.StoreDataId).ValueGeneratedOnAdd();
            entity.Property(e => e.StoreEmail).HasMaxLength(50);
            entity.Property(e => e.StoreMobil).HasMaxLength(40);
            entity.Property(e => e.StoreName).HasMaxLength(50);
            entity.Property(e => e.StorePhone).HasMaxLength(11);
            entity.Property(e => e.StoreWhatsapp).HasMaxLength(11);

            entity.HasOne(d => d.AccountsName).WithMany(p => p.StoreData)
                .HasForeignKey(d => d.AccountsNameId)
                .HasConstraintName("FK_StoreData_AccountName");

            entity.HasOne(d => d.BranchesData).WithMany(p => p.StoreData)
                .HasForeignKey(d => d.BranchesDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StoresData_BranchesData");

            entity.HasOne(d => d.CityCode).WithMany(p => p.StoreData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_StoresData_CityCode");

            entity.HasOne(d => d.StoreManagerNavigation).WithMany(p => p.StoreData)
                .HasForeignKey(d => d.StoreManager)
                .HasConstraintName("FK_StoreData_EmployeesData");
        });

        modelBuilder.Entity<SupplierData>(entity =>
        {
            entity.HasKey(e => e.Supplierid);

            entity.Property(e => e.Supplierid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AdditionalInformation).HasMaxLength(100);
            entity.Property(e => e.BuildingNumber).HasMaxLength(5);
            entity.Property(e => e.CommercialRegisterNumber).HasMaxLength(10);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.FloorNumber).HasMaxLength(5);
            entity.Property(e => e.IsCompany).HasDefaultValue(false);
            entity.Property(e => e.IsCustomer).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.IsNotActiveTax).HasDefaultValue(false);
            entity.Property(e => e.LandMark).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(14);
            entity.Property(e => e.PostalCode).HasMaxLength(7);
            entity.Property(e => e.RoomNumber).HasMaxLength(3);
            entity.Property(e => e.SupplierAddress).HasMaxLength(100);
            entity.Property(e => e.SupplierBarCode)
                .HasMaxLength(13)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.SupplierEmail).HasMaxLength(50);
            entity.Property(e => e.SupplierFax).HasMaxLength(10);
            entity.Property(e => e.SupplierMobil).HasMaxLength(40);
            entity.Property(e => e.SupplierName).HasMaxLength(75);
            entity.Property(e => e.SupplierPhone).HasMaxLength(10);
            entity.Property(e => e.SupplierWhatsapp).HasMaxLength(11);
            entity.Property(e => e.TaxRegistrationNumber).HasMaxLength(10);
            entity.Property(e => e.TaxesErrand).HasMaxLength(50);

            entity.HasOne(d => d.AccountsName).WithMany(p => p.SupplierData)
                .HasForeignKey(d => d.AccountsNameId)
                .HasConstraintName("FK_SupplierData_AccountName");

            entity.HasOne(d => d.CityCode).WithMany(p => p.SupplierData)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_SupplierData_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.SupplierData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierData_CompanyData");

            entity.HasOne(d => d.SupplierGroups).WithMany(p => p.SupplierData)
                .HasForeignKey(d => d.SupplierGroupsId)
                .HasConstraintName("FK_SupplierData_SupplierGroups");

            entity.HasOne(d => d.SupplierManagerNavigation).WithMany(p => p.SupplierData)
                .HasForeignKey(d => d.SupplierManager)
                .HasConstraintName("FK_SupplierData_EmployeesData");
        });

        modelBuilder.Entity<SupplierGroup>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.CategoryNameL1).HasMaxLength(50);
            entity.Property(e => e.CategoryNameL2).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxableType>(entity =>
        {
            entity.HasKey(e => e.TaxId).HasName("PK_TaxType");

            entity.ToTable("TaxableType");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.TaxNameL1).HasMaxLength(50);
            entity.Property(e => e.TaxNameL2).HasMaxLength(50);
            entity.Property(e => e.TaxPercent).HasDefaultValue(0.0);
            entity.Property(e => e.TaxTable).HasMaxLength(4);

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation)
                .HasForeignKey(d => d.ParentCode)
                .HasConstraintName("FK_TaxData_TaxData");
        });

        modelBuilder.Entity<TransformationsDetail>(entity =>
        {
            entity.HasKey(e => e.TransDetailId);

            entity.Property(e => e.TransDetailId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Price).HasDefaultValue(0.0);
            entity.Property(e => e.Quantity).HasDefaultValue(0.0);
            entity.Property(e => e.Value).HasDefaultValue(0.0);

            entity.HasOne(d => d.ItemsHeader).WithMany(p => p.TransformationsDetails)
                .HasForeignKey(d => d.ItemsHeaderId)
                .HasConstraintName("FK_TransformationsDetails_ItemsHeader");

            entity.HasOne(d => d.TransformationsMaster).WithMany(p => p.TransformationsDetails)
                .HasForeignKey(d => d.TransformationsMasterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TransformationsDetails_TransformationsMaster");

            entity.HasOne(d => d.UnitType).WithMany(p => p.TransformationsDetails)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("FK_TransformationsDetails_UnitType");
        });

        modelBuilder.Entity<TransformationsMaster>(entity =>
        {
            entity.HasKey(e => e.TransMasterId);

            entity.ToTable("TransformationsMaster");

            entity.Property(e => e.TransMasterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.TransformationNo).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CompanyData).WithMany(p => p.TransformationsMasters)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TransformationsMaster_CompanyData");

            entity.HasOne(d => d.From).WithMany(p => p.TransformationsMasterFroms)
                .HasForeignKey(d => d.FromId)
                .HasConstraintName("FK_TransformationsMaster_StoreData");

            entity.HasOne(d => d.To).WithMany(p => p.TransformationsMasterTos)
                .HasForeignKey(d => d.ToId)
                .HasConstraintName("FK_TransformationsMaster_StoreData1");
        });

        modelBuilder.Entity<UnitType>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK_ItemsUnit");

            entity.ToTable("UnitType");

            entity.Property(e => e.CodeTax).HasMaxLength(10);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.UnitNameL1).HasMaxLength(70);
            entity.Property(e => e.UnitNameL2).HasMaxLength(70);
        });

        modelBuilder.Entity<UniversityDatum>(entity =>
        {
            entity.HasKey(e => e.UniversityDataId).HasName("PK_UniversityName");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.UniversityDataNameL1).HasMaxLength(40);
            entity.Property(e => e.UniversityDataNameL2).HasMaxLength(40);
        });

        modelBuilder.Entity<UserStatisticForOrderStatus>(entity =>
        {
            entity.HasKey(e => e.StatisticId);

            entity.ToTable("UserStatisticForOrderStatus");

            entity.Property(e => e.StatisticId).ValueGeneratedNever();
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewAccountsBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAccountsBalance");

            entity.Property(e => e.AccountFicationNameL1).HasMaxLength(50);
            entity.Property(e => e.AccountNameL1).HasMaxLength(100);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BalanceNameL1).HasMaxLength(50);
            entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ViewAspNetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAspNetUsers");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<ViewBankAtmorder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewBankATMOrder");

            entity.Property(e => e.Atmcode)
                .HasMaxLength(50)
                .HasColumnName("ATMCode");
            entity.Property(e => e.Atmmodel)
                .HasMaxLength(50)
                .HasColumnName("ATMModel");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.CityNameL1).HasMaxLength(75);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.GovernorateNameL1).HasMaxLength(75);
        });

        modelBuilder.Entity<ViewCompanyUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewCompanyUser");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViewImageComment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewImage_Comment");
        });

        modelBuilder.Entity<ViewItemsGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewItemsGroup");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.ItemCodeTax).HasMaxLength(20);
            entity.Property(e => e.ItemGroupNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemGroupNameL2).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewItemsGroupItemsHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewItemsGroup_ItemsHeader");

            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.ItemGroupNameL1).HasMaxLength(50);
            entity.Property(e => e.ItemGroupNameL2).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPlanWorkWeb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewPlanWorkWeb");

            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.Atmaddress).HasColumnName("ATMAddress");
            entity.Property(e => e.Atmcode)
                .HasMaxLength(50)
                .HasColumnName("ATMCode");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.DetailsDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSelectJournal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSelectJournal");

            entity.Property(e => e.AccountNameL1).HasMaxLength(100);
            entity.Property(e => e.CenterName).HasMaxLength(50);
            entity.Property(e => e.CurrencyNameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSelectReportOwner>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSelectReportOwner");

            entity.Property(e => e.Atmcode)
                .HasMaxLength(50)
                .HasColumnName("ATMCode");
            entity.Property(e => e.Atmmodel)
                .HasMaxLength(50)
                .HasColumnName("ATMModel");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.BanknameL1).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.DelegateNameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSelectReportWorkPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSelectReportWorkPlan");

            entity.Property(e => e.Atmcode)
                .HasMaxLength(50)
                .HasColumnName("ATMCode");
            entity.Property(e => e.Atmmodel)
                .HasMaxLength(50)
                .HasColumnName("ATMModel");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.BanknameL1).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.DelegateNameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewWorkPlanOrderNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewWorkPlanOrderNew");

            entity.Property(e => e.Atmcode)
                .HasMaxLength(50)
                .HasColumnName("ATMCode");
            entity.Property(e => e.Atmmodel)
                .HasMaxLength(50)
                .HasColumnName("ATMModel");
            entity.Property(e => e.Atmserial)
                .HasMaxLength(50)
                .HasColumnName("ATMSerial");
            entity.Property(e => e.BanknameL1).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.DelegateNameL1).HasMaxLength(50);
        });

        modelBuilder.Entity<WhatsAppCompanyData>(entity =>
        {
            entity.HasKey(e => e.WhatsId).HasName("PK_WhatsApp_Data");

            entity.ToTable("WhatsApp_CompanyData");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.InstanceId).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.MobilNo).HasMaxLength(11);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.Token).HasMaxLength(50);
        });

        modelBuilder.Entity<WhatsAppMessageData>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.MessageNo });

            entity.ToTable("WhatsApp_MessageData");

            entity.Property(e => e.MessageId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MessageNo).ValueGeneratedOnAdd();
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.CompanyData).WithMany(p => p.WhatsAppMessageData)
                .HasForeignKey(d => d.CompanyDataId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WhatsApp_MessageData_CompanyData");
        });

        modelBuilder.Entity<WhatsAppResult>(entity =>
        {
            entity.HasKey(e => new { e.ResultId, e.ResultNo });

            entity.ToTable("WhatsApp_Result");

            entity.Property(e => e.ResultId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ResultNo).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsNotactive).HasDefaultValue(true);
            entity.Property(e => e.Isdeleted).HasDefaultValue(true);
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            entity.Property(e => e.SendDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<WhatsAppUrl>(entity =>
        {
            entity.HasKey(e => e.WhatsUrlid);

            entity.ToTable("WhatsApp_URL");

            entity.Property(e => e.WhatsUrlid).HasColumnName("WhatsURLId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.MessageType).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.RequestUrl)
                .HasMaxLength(50)
                .HasColumnName("RequestURL");
        });

        modelBuilder.Entity<WorkPlanComment>(entity =>
        {
            entity.HasKey(e => e.CommentId);

            entity.Property(e => e.CommentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.WorkPlanFooter).WithMany(p => p.WorkPlanComments)
                .HasForeignKey(d => d.WorkPlanFooterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkPlanComments_WorkPlanFooters");
        });

        modelBuilder.Entity<WorkPlanDetail>(entity =>
        {
            entity.HasKey(e => e.DetailsId);

            entity.Property(e => e.DetailsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OrderNumberDetails).ValueGeneratedOnAdd();

            entity.HasOne(d => d.WorkPlanFooter).WithMany(p => p.WorkPlanDetails)
                .HasForeignKey(d => d.WorkPlanFooterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkPlanDetails_WorkPlanFooters");
        });

        modelBuilder.Entity<WorkPlanFooter>(entity =>
        {
            entity.HasKey(e => e.FooterId).HasName("PK_WorkPlanFooters_1");

            entity.Property(e => e.FooterId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.BankAtmid).HasColumnName("BankATMId");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);
            entity.Property(e => e.OrderNumberFooter).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AspNetUsers).WithMany(p => p.WorkPlanFooters)
                .HasForeignKey(d => d.AspNetUsersId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkPlanFooters_AspNetUsers");

            entity.HasOne(d => d.BankAtm).WithMany(p => p.WorkPlanFooters)
                .HasForeignKey(d => d.BankAtmid)
                .HasConstraintName("FK_WorkPlanFooters_BankATM");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.WorkPlanFooters)
                .HasForeignKey(d => d.OrderStatusId)
                .HasConstraintName("FK_WorkPlanFooters_OrderStatuses");

            entity.HasOne(d => d.WorkPlanHeader).WithMany(p => p.WorkPlanFooters)
                .HasForeignKey(d => d.WorkPlanHeaderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkPlanFooters_WorkPlanHeaders");
        });

        modelBuilder.Entity<WorkPlanHeader>(entity =>
        {
            entity.HasKey(e => e.WorkPlanId);

            entity.Property(e => e.WorkPlanId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AspNetUsersId).HasMaxLength(450);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUserId).HasMaxLength(50);
            entity.Property(e => e.CreateUserName).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Deletedby).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(true);
            entity.Property(e => e.IsNotActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby).HasMaxLength(50);

            entity.HasOne(d => d.BankCode).WithMany(p => p.WorkPlanHeaders)
                .HasForeignKey(d => d.BankCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkPlanHeaders_BankCode");

            entity.HasOne(d => d.CityCode).WithMany(p => p.WorkPlanHeaders)
                .HasForeignKey(d => d.CityCodeId)
                .HasConstraintName("FK_WorkPlanHeaders_CityCode");

            entity.HasOne(d => d.CompanyData).WithMany(p => p.WorkPlanHeaders)
                .HasForeignKey(d => d.CompanyDataId)
                .HasConstraintName("FK_WorkPlanHeaders_CompanyData");

            entity.HasOne(d => d.GovernorateCode).WithMany(p => p.WorkPlanHeaders)
                .HasForeignKey(d => d.GovernorateCodeId)
                .HasConstraintName("FK_WorkPlanHeaders_GovernorateCode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
