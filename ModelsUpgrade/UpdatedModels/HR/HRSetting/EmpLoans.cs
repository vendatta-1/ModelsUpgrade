using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpLoans : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? EmployeesDataId { get; set; }

        public Guid? EmpLoansTypeId { get; set; }
        public DateInfo DateInfo { get; set; }
        public double? ValueMonth { get; set; } = 0.0;

        public short? MonthLoans { get; set; } = 0;

        public virtual EmpLoansType EmpLoansType { get; set; }

        public virtual EmployeeData EmployeesData { get; set; }

    }
}
