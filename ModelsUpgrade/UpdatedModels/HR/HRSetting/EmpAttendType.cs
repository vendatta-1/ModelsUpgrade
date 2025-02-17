using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpAttendType : NamedEntity
    {
        public virtual ICollection<EmpAttend> EmpAttends { get; set; } = new HashSet<EmpAttend>();
    }
}
