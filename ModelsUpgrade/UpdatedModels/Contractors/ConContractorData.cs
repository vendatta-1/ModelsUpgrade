using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Contractors;

public class ConContractorData : Entity
{


    #region FK
    public Guid? CompanyDataId { get; set; }
    public Guid? ContractorGroupsId { get; set; }
    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }
    public Guid? ContractorManagerId { get; set; }
    public Guid? AccountsNameId { get; set; }
    #endregion
    [MaxLength(50)]
    public string ContractorBarCode { get; set; }
    [MaxLength(75)]
    public string ContractorName { get; set; }
    public ObjectCompleteAddress ContractorAddress { get; set; }

    public ContactInfo ContactInfo { get; set; }

    [MaxLength(100)]
    public string AdditionalInformation { get; set; }
    [MaxLength(14)]
    public string NationalId { get; set; }


    public bool? IsCustomer { get; set; }

    public bool? IsCompany { get; set; }

    public bool? IsNotActiveTax { get; set; }
    [MaxLength(10)]
    public string TaxRegistrationNumber { get; set; }
    [MaxLength(50)]
    public string TaxesErrand { get; set; }
    [MaxLength(10)]
    public string CommercialRegisterNumber { get; set; }

    public Duration? ContractorDuration { get; set; }
    [MaxLength(200)]
    public string Description { get; set; }
    [MaxLength(250)]
    public string ImageUrl { get; set; }


    public virtual AccountName AccountsName { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }


    public virtual ICollection<ConContractorExtractMaster> ConContractorExtractMasters { get; set; } = new HashSet<ConContractorExtractMaster>();

    public virtual SupplierGroup ContractorGroups { get; set; }

    //public virtual EmployeeData ContractorManagerNavigation { get; set; }
    ///new Addations
    public virtual EmployeeData ContractorManager { get; set; }

    public virtual GovernorateCode GovernorateCode { get; set; }

    public virtual CountryCode CountryCode { get; set; }
}
