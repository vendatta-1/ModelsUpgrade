using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;

namespace ModelsUpgrade.UpdatedModels.BankSystem;

public class BankAtm : Entity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? BankCodeId { get; set; }

    public DateOnly? StartDate { get; set; }

    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }

    public string AtmModel { get; set; }

    public string AtmSerial { get; set; }

    public string AtmCode { get; set; }

    public string AtmAddress { get; set; }

    public int? AtmcounterForMonth { get; set; } = 0;

    public string AtmLocation { get; set; }

    public string AtmLong { get; set; }

    public string AtmLat { get; set; }

    public bool? IsPosted { get; set; }

    public virtual BankCode BankCode { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }
    public virtual BranchesData BranchesData { get; set; }
    public virtual GovernorateCode GovernorateCode { get; set; }
    public virtual CountryCode CountryCode { get; set; }
    public virtual ICollection<WorkPlanFooter> WorkPlanFooters { get; set; } = new HashSet<WorkPlanFooter>();
}
