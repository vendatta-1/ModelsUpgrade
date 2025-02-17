using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpLevelType : NamedEntity
    {
        public virtual ICollection<EmpLevel> EmpLevels { get; set; } = new HashSet<EmpLevel>();
    }
}
