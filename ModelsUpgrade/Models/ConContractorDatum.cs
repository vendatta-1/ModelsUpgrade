using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ConContractorDatum
{
    public Guid ContractorId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public long? ContractorGroupsId { get; set; }

    public string ContractorBarCode { get; set; }

    public string ContractorName { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string ContractorAddress { get; set; }

    public string BuildingNumber { get; set; }

    public string PostalCode { get; set; }

    public string FloorNumber { get; set; }

    public string RoomNumber { get; set; }

    public string LandMark { get; set; }

    public string AdditionalInformation { get; set; }

    public string NationalId { get; set; }

    public string ContractorMobil { get; set; }

    public string ContractorPhone { get; set; }

    public string ContractorFax { get; set; }

    public string ContractorWhatsapp { get; set; }

    public string ContractorEmail { get; set; }

    public Guid? ContractorManager { get; set; }

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

    public virtual ICollection<ConContractorExtractMaster> ConContractorExtractMasters { get; set; } = new List<ConContractorExtractMaster>();

    public virtual SupplierGroup ContractorGroups { get; set; }

    public virtual EmployeeDatum ContractorManagerNavigation { get; set; }
}
