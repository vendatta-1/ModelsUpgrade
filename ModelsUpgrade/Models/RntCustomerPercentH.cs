using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntCustomerPercentH
{
    public Guid PercentId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateTime? DistributeDate { get; set; }

    public double? TotalRevenu { get; set; }

    public double? TotalExpenses { get; set; }

    public double? NetRevenu { get; set; }

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

    public virtual BranchesData BranchesData { get; set; }

    public virtual CustomerDatum CustomerData { get; set; }

    public virtual ICollection<RntCustomerPercentD> RntCustomerPercentDs { get; set; } = new List<RntCustomerPercentD>();
}
