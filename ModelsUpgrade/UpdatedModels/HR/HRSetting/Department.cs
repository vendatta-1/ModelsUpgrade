using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;

namespace ModelsUpgrade.UpdatedModels.HR;

public class Department : NamedEntity
{


    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();
}
