using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class Possession
{
    public Guid SessionId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? EmployeesDataId { get; set; }

    public DateTime? DateHeureOpen { get; set; }

    public DateTime? DateHeureClose { get; set; }

    public double? TotalValue { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual EmployeeDatum EmployeesData { get; set; }
}
