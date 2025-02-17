
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpGroupWork : NamedEntity
    {
        public Guid? CompanyDataId { get; set; }//here there is a branch navigation but not Company

        public Guid? BranchesDataId { get; set; }
        public EmpGroupTimeInfo? TimeInfo { get; set; }

        public int? Accept { get; set; } = 0;

        public int? EmployeeLevel { get; set; } = 0;

        public bool? OverTime { get; set; }

        public TimeOnly? TotalTime { get; set; }

        public bool? TotalTimeNotActive { get; set; }
        public virtual BranchesData BranchesData { get; set; }

        public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();

    }
}
