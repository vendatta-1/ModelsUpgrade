using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Education;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class GenderData : NamedEntity
    {
        public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new HashSet<EduStudentData>();

        public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();
    }
}
