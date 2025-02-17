using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class ApplicationMenu : NamedEntity
    {
        public long? MenuUd { get; set; }
        public Guid? ParentCode { get; set; }//new changes

        public int? LevelCode { get; set; } = 0;

        public bool? IsPosted { get; set; } = true;

        public virtual ICollection<AspPermission> AspPermissions { get; set; } = new HashSet<AspPermission>();

        public virtual BranchesData BranchesData { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual ICollection<ProgramOption> ProgramOptions { get; set; } = new HashSet<ProgramOption>();

        public virtual ICollection<ReportsName> ReportsNames { get; set; } = new HashSet<ReportsName>();
    }
}
