using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpLoan
{
    public long LoansId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? EmployeesDataId { get; set; }

    public long? EmpLoansTypeId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public double? Value { get; set; }

    public double? ValueMonth { get; set; }

    public int? MonthLoans { get; set; }

    public string Description { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual EmpLoansType EmpLoansType { get; set; }

    public virtual EmployeeDatum EmployeesData { get; set; }
}
