using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;

namespace ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;

public class WorkPlanHeader : HeaderEntity
{


    public Guid? BankCodeId { get; set; }

    public Duration? WorkPlanDuration { get; set; }

    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }

    //[MaxLength(450)]
    //public string AspNetUsersId { get; set; }


    public virtual BankCode BankCode { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CountryCode CountryCode { get; set; }
    public virtual GovernorateCode GovernorateCode { get; set; }

    public virtual ICollection<WorkPlanFooter> WorkPlanFooters { get; set; } = new HashSet<WorkPlanFooter>();
}
