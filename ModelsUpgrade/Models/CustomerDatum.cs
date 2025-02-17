namespace Link_Entities.Models;

public partial class CustomerDatum
{
    public Guid CustomerId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public long? CustomerCategoriesId { get; set; }

    public Guid? CustomerBarCode { get; set; }

    public string CustomerName { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string CustomerAddress { get; set; }

    public string BuildingNumber { get; set; }

    public string PostalCode { get; set; }

    public string FloorNumber { get; set; }

    public string RoomNumber { get; set; }

    public string LandMark { get; set; }

    public string AdditionalInformation { get; set; }

    public long? CustomerModesId { get; set; }

    public string NationalId { get; set; }

    public string CustomerMobil { get; set; }

    public string CustomerPhone { get; set; }

    public string CustomerFax { get; set; }

    public string CustomerWhatsapp { get; set; }

    public string CustomerEmail { get; set; }

    public bool? IsNotActiveTax { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsCompany { get; set; }

    public string TaxRegistrationNumber { get; set; }

    public string TaxesErrand { get; set; }

    public string CommercialRegisterNumber { get; set; }

    public Guid? RepresentativeDataId { get; set; }

    public Guid? AccountsNameSalesId { get; set; }

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

    public virtual AccountName AccountsNameSales { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual CustomerCategory CustomerCategories { get; set; }

    public virtual CustomerMode CustomerModes { get; set; }

    public virtual ICollection<HotelPayment> HotelPayments { get; set; } = new List<HotelPayment>();

    public virtual ICollection<HotelReservationMaster> HotelReservationMasters { get; set; } = new List<HotelReservationMaster>();

    public virtual ICollection<InstallmentHeader> InstallmentHeaders { get; set; } = new List<InstallmentHeader>();

    public virtual ICollection<MedCustomerDetail> MedCustomerDetails { get; set; } = new List<MedCustomerDetail>();

    public virtual ICollection<MedCustomerMedicalService> MedCustomerMedicalServices { get; set; } = new List<MedCustomerMedicalService>();

    public virtual ICollection<MedCustomerSurgicalService> MedCustomerSurgicalServices { get; set; } = new List<MedCustomerSurgicalService>();

    public virtual ICollection<PosSale> Possales { get; set; } = new List<PosSale>();

    public virtual DelegateDatum RepresentativeData { get; set; }

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new List<ReturnSalesHeader>();

    public virtual ICollection<RntContractsH> RntContractsHes { get; set; } = new List<RntContractsH>();

    public virtual ICollection<RntCustomerPercentH> RntCustomerPercentHs { get; set; } = new List<RntCustomerPercentH>();

    public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new List<SalesInvoiceHeader>();
}
