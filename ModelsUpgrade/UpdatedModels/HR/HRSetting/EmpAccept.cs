using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpAccept : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? EmployeesDataId { get; set; }

        public Guid? EmpAcceptTypeId { get; set; }
        public double? Value { get; set; } = 0.0;
        public HRDateInfo DateInfo { get; set; }

        public string Description { get; set; }
        public virtual EmpAcceptType EmpAcceptType { get; set; }

        public virtual EmployeeData EmployeesData { get; set; }

        //new navigation//
        //public virtual CompanyData CompanyData { get; set; }
        //public virtual BranchesData BranchesData { get; set; }


    }
}
