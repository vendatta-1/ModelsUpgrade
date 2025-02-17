using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpDayWeek : NamedEntity
    {
        public virtual ICollection<EmpAttend> EmpAttends { get; set; } = new HashSet<EmpAttend>();
    }
}
