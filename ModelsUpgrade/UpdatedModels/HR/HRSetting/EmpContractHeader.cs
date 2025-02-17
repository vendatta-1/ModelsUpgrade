
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpContractHeader : HeaderEntity
    {


        public Guid? EmployeesDataId { get; set; }

        public Guid? EmpContractTypeId { get; set; }

        public Duration ContractDuration { get; set; }

        public virtual ICollection<EmpContractFooter> EmpContractDetalis { get; set; } = new HashSet<EmpContractFooter>();

        public virtual EmpContractType EmpContractType { get; set; }

        public virtual EmployeeData EmployeesData { get; set; }
    }
}
