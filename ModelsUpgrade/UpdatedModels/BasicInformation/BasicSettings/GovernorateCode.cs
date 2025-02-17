
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BankSystem;
using ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;

namespace ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings
{
    public class GovernorateCode : NamedEntity
    {
        public GovernorateCode(Guid id) : base(id) { }
        protected GovernorateCode()
        {

        }

        public Guid? CountryCodeId { get; set; }
        public virtual ICollection<BankAtm> BankAtms { get; set; } = new HashSet<BankAtm>();

        public virtual ICollection<BankCode> BankCodes { get; set; } = new HashSet<BankCode>();

        public virtual ICollection<CityCode> CityCodes { get; set; } = new HashSet<CityCode>();

        public virtual CountryCode CountryCode { get; set; }

        public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new HashSet<WorkPlanHeader>();

    }
}
