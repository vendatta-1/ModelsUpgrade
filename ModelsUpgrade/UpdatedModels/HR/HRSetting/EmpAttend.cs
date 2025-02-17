
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpAttend : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? EmployeesDataId { get; set; }

        public Guid? AttendTypeId { get; set; }

        public Guid? EmpDayWeekId { get; set; }
        public DateInfo DateInfo { get; set; }
        public EmpAttendTimeInfo TimeInfo { get; set; }
        public bool? IsPosted { get; set; } = true;


        public virtual EmpAttendType AttendType { get; set; }

        public virtual EmpDayWeek EmpDayWeek { get; set; }

        public virtual EmployeeData EmployeesData { get; set; }
    }
}
