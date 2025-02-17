
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ProgramSetting;

namespace ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings
{
    public class CountryCode : NamedEntity
    {

        public CountryCode(Guid id) : base(id) { }
        protected CountryCode() { }
        public string CodeTaxTabel { get; set; }

        public bool? IsPosted { get; set; }


        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; } = new HashSet<ApplicationSetting>();

        public virtual ICollection<GovernorateCode> GovernorateCodes { get; set; } = new HashSet<GovernorateCode>();
    }
}
