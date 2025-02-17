using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpLevel : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? EmployeesDataId { get; set; }

        public EmpLeveDateInfo? DateInfo { get; set; }
        public Guid? EmpLevelTypeId { get; set; }

        public double? Value { get; set; } = 0.0;

        public string Description { get; set; } = string.Empty;
        public virtual EmpLevelType EmpLevelType { get; set; }

        public virtual EmployeeData EmployeesData { get; set; }

    }
}
