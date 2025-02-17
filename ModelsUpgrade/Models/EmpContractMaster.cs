using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpContractMaster
{
    public Guid ContractId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? EmployeesDataId { get; set; }

    public long? EmpContractTypeId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EmpContractDetali> EmpContractDetalis { get; set; } = new List<EmpContractDetali>();

    public virtual EmpContractType EmpContractType { get; set; }

    public virtual EmployeeDatum EmployeesData { get; set; }
}
