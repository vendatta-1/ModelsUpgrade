using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AccountName
{
    public Guid AccountId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string AccountNumber { get; set; }

    public string AccountNameL1 { get; set; }

    public string AccountNameL2 { get; set; }

    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public long? CurrencyDataId { get; set; }

    public long? AccountFicationId { get; set; }

    public long? AccountMenuId { get; set; }

    public long? AccountTypeId { get; set; }

    public long? AccountNatureId { get; set; }

    public bool? NotMenu { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountFication AccountFication { get; set; }

    public virtual ICollection<AccountFixedDetail> AccountFixedDetailAccountNameLevel2s { get; set; } = new List<AccountFixedDetail>();

    public virtual ICollection<AccountFixedDetail> AccountFixedDetailAccountNames { get; set; } = new List<AccountFixedDetail>();

    public virtual AccountMenu AccountMenu { get; set; }

    public virtual AccountNature AccountNature { get; set; }

    public virtual AccountType AccountType { get; set; }

    public virtual ICollection<AccountsBalanceFooter> AccountsBalanceFooters { get; set; } = new List<AccountsBalanceFooter>();

    public virtual ICollection<CheckDetail> CheckDetailAccountNameFromNavigations { get; set; } = new List<CheckDetail>();

    public virtual ICollection<CheckDetail> CheckDetailAccountNameToNavigations { get; set; } = new List<CheckDetail>();

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ConContractorDatum> ConContractorData { get; set; } = new List<ConContractorDatum>();

    public virtual ICollection<ConProjectsData> ConProjectsData { get; set; } = new List<ConProjectsData>();

    public virtual CurrencyDatum CurrencyData { get; set; }

    public virtual ICollection<CustomerDatum> CustomerData { get; set; } = new List<CustomerDatum>();

    public virtual ICollection<DelegateDatum> DelegateData { get; set; } = new List<DelegateDatum>();

    public virtual ICollection<FinancialCenter> FinancialCenters { get; set; } = new List<FinancialCenter>();

    public virtual ICollection<GeneralAccountFooter> GeneralAccountFooters { get; set; } = new List<GeneralAccountFooter>();

    public virtual ICollection<AccountName> InverseParentCodeNavigation { get; set; } = new List<AccountName>();

    public virtual ICollection<JournalFooter> JournalFooters { get; set; } = new List<JournalFooter>();

    public virtual ICollection<LockersDatum> LockersData { get; set; } = new List<LockersDatum>();

    public virtual ICollection<MoneyPayment> MoneyPaymentFromAccountNames { get; set; } = new List<MoneyPayment>();

    public virtual ICollection<MoneyPayment> MoneyPaymentFromCashes { get; set; } = new List<MoneyPayment>();

    public virtual ICollection<MoneyPayment> MoneyPaymentToAccountNames { get; set; } = new List<MoneyPayment>();

    public virtual ICollection<MoneyReceive> MoneyReceiveFromAccountNames { get; set; } = new List<MoneyReceive>();

    public virtual ICollection<MoneyReceive> MoneyReceiveFromCashes { get; set; } = new List<MoneyReceive>();

    public virtual ICollection<MoneyReceive> MoneyReceiveToAccountNames { get; set; } = new List<MoneyReceive>();

    public virtual AccountName ParentCodeNavigation { get; set; }

    public virtual ICollection<PItemsHeader> PitemsHeaderAccountNameSales { get; set; } = new List<PItemsHeader>();

    public virtual ICollection<PItemsHeader> PitemsHeaderAccountsNamePurchas { get; set; } = new List<PItemsHeader>();

    public virtual ICollection<StoreData> StoreData { get; set; } = new List<StoreData>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new List<SupplierData>();
}
