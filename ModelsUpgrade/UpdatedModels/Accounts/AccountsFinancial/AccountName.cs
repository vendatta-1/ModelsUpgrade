using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.MoneySetting;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.Contractors;
using ModelsUpgrade.UpdatedModels.Fixed;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

public class AccountName : NamedEntity
{
    public AccountName(Guid id) : base(id) { }
    protected AccountName() { }
    public Guid? CompanyDataId { get; set; }
    [MaxLength(50)]
    public string AccountNumber { get; set; }


    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public Guid? CurrencyDataId { get; set; }

    public Guid? AccountFicationId { get; set; }

    public Guid? AccountMenuId { get; set; }

    public Guid? AccountTypeId { get; set; }

    public Guid? AccountNatureId { get; set; }

    public bool? NotMenu { get; set; }

    public virtual AccountFication AccountFication { get; set; }

    public virtual ICollection<AccountFixedDetail> AccountFixedDetailAccountNameLevel2s { get; set; } = new HashSet<AccountFixedDetail>();

    public virtual ICollection<AccountFixedDetail> AccountFixedDetailAccountNames { get; set; } = new HashSet<AccountFixedDetail>();

    public virtual AccountMenu AccountMenu { get; set; }

    public virtual AccountNature AccountNature { get; set; }

    public virtual AccountType AccountType { get; set; }

    public virtual ICollection<AccountsBalanceFooter> AccountsBalanceFooters { get; set; } = new HashSet<AccountsBalanceFooter>();

    public virtual ICollection<CheckDetail> CheckDetailAccountNameFromNavigations { get; set; } = new HashSet<CheckDetail>();

    public virtual ICollection<CheckDetail> CheckDetailAccountNameToNavigations { get; set; } = new HashSet<CheckDetail>();

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ConContractorData> ConContractorData { get; set; } = new HashSet<ConContractorData>();

    public virtual ICollection<ConProjectsData> ConProjectsData { get; set; } = new HashSet<ConProjectsData>();

    public virtual CurrencyData CurrencyData { get; set; }

    public virtual ICollection<CustomerData> CustomerData { get; set; } = new HashSet<CustomerData>();

    public virtual ICollection<DelegateData> DelegateData { get; set; } = new HashSet<DelegateData>();

    public virtual ICollection<FinancialCenter> FinancialCenters { get; set; } = new HashSet<FinancialCenter>();

    public virtual ICollection<GeneralAccountFooter> GeneralAccountFooters { get; set; } = new HashSet<GeneralAccountFooter>();

    public virtual ICollection<AccountName> InverseParentCodeNavigation { get; set; } = new HashSet<AccountName>();

    public virtual ICollection<JournalFooter> JournalFooters { get; set; } = new HashSet<JournalFooter>();

    public virtual ICollection<LockersData> LockersData { get; set; } = new HashSet<LockersData>();

    public virtual ICollection<MoneyPayment> MoneyPaymentFromAccountNames { get; set; } = new HashSet<MoneyPayment>();

    public virtual ICollection<MoneyPayment> MoneyPaymentFromCashes { get; set; } = new HashSet<MoneyPayment>();

    public virtual ICollection<MoneyPayment> MoneyPaymentToAccountNames { get; set; } = new HashSet<MoneyPayment>();

    public virtual ICollection<MoneyReceive> MoneyReceiveFromAccountNames { get; set; } = new HashSet<MoneyReceive>();

    public virtual ICollection<MoneyReceive> MoneyReceiveFromCashes { get; set; } = new HashSet<MoneyReceive>();

    public virtual ICollection<MoneyReceive> MoneyReceiveToAccountNames { get; set; } = new HashSet<MoneyReceive>();

    public virtual AccountName ParentCodeNavigation { get; set; }

    public virtual ICollection<PItemsHeader> PitemsHeaderAccountNameSales { get; set; } = new HashSet<PItemsHeader>();

    public virtual ICollection<PItemsHeader> PitemsHeaderAccountsNamePurchas { get; set; } = new HashSet<PItemsHeader>();

    public virtual ICollection<StoreData> StoreData { get; set; } = new HashSet<StoreData>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new HashSet<SupplierData>();
}
