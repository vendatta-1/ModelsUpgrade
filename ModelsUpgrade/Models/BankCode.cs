namespace Link_Entities.Models;

public partial class BankCode
{
    public long BankId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string BanknameL1 { get; set; }

    public string BanknameL2 { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string BankAddress { get; set; }

    public string BankMobil { get; set; }

    public string BankPhone { get; set; }

    public string BankEmail { get; set; }

    public string BankAccountNo { get; set; }

    public long? CurrencyDataId { get; set; }

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

    public virtual ICollection<AspNetUser> AspNetUsers { get; set; } = new List<AspNetUser>();

    public virtual ICollection<BankAtm> BankAtms { get; set; } = new List<BankAtm>();

    public virtual ICollection<BankContract> BankContracts { get; set; } = new List<BankContract>();

    public virtual ICollection<CheckDetail> CheckDetails { get; set; } = new List<CheckDetail>();

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual CurrencyDatum CurrencyData { get; set; }

    public virtual GovernorateCode GovernorateCode { get; set; }

    public virtual ICollection<SalesInvoicePayment> SalesInvoicePayments { get; set; } = new List<SalesInvoicePayment>();

    public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new List<WorkPlanHeader>();
}
