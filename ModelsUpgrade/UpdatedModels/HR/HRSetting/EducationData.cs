using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Education;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
    ;

public class EducationData : NamedEntity
{

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new HashSet<EduStudentData>();

    public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();
}
