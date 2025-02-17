using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Medical;
public class MedPartnerData : NamedEntity
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PartnerDataNumber { get; set; }


    [MaxLength(200)]
    public string PartnerDataBarCode { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? JobDataId { get; set; }

    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }
    [MaxLength(250)]
    public string PartnerAddress { get; set; }

    public ContactInfo PartnerContacInfo { get; set; }

    public string ImageUrl { get; set; }


    public virtual BranchesData BranchesData { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual JobData JobData { get; set; }

}
