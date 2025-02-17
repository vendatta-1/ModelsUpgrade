namespace Link_Entities.Models;

public partial class SupplierData
{
    public Guid Supplierid { get; set; }

    public Guid? CompanyDataId { get; set; }

    public long? SupplierGroupsId { get; set; }

    public string SupplierBarCode { get; set; }

    public string SupplierName { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string SupplierAddress { get; set; }

    public string BuildingNumber { get; set; }

    public string PostalCode { get; set; }

    public string FloorNumber { get; set; }

    public string RoomNumber { get; set; }

    public string LandMark { get; set; }

    public string AdditionalInformation { get; set; }

    public string NationalId { get; set; }

    public string SupplierMobil { get; set; }

    public string SupplierPhone { get; set; }

    public string SupplierFax { get; set; }

    public string SupplierWhatsapp { get; set; }

    public string SupplierEmail { get; set; }

    public Guid? SupplierManager { get; set; }

    public bool? IsCustomer { get; set; }

    public bool? IsCompany { get; set; }

    public bool? IsNotActiveTax { get; set; }

    public Guid? AccountsNameId { get; set; }

    public string TaxRegistrationNumber { get; set; }

    public string TaxesErrand { get; set; }

    public string CommercialRegisterNumber { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

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

    public virtual AccountName AccountsName { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new List<ItemsHeader>();

    public virtual ICollection<ItemsPricePurchase> ItemsPricePurchases { get; set; } = new List<ItemsPricePurchase>();

    public virtual ICollection<PItemsHeader> PitemsHeaders { get; set; } = new List<PItemsHeader>();

    public virtual ICollection<PpurchasesInvoiceHeader> PpurchasesInvoiceHeaders { get; set; } = new List<PpurchasesInvoiceHeader>();

    public virtual ICollection<PreturnPurchasesHeader> PreturnPurchasesHeaders { get; set; } = new List<PreturnPurchasesHeader>();

    public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new List<PurchasesInvoiceHeader>();

    public virtual ICollection<PurchasesOrderHeader> PurchasesOrderHeaders { get; set; } = new List<PurchasesOrderHeader>();

    public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new List<ReturnPurchasesHeader>();

    public virtual SupplierGroup SupplierGroups { get; set; }

    public virtual EmployeeDatum SupplierManagerNavigation { get; set; }
}
