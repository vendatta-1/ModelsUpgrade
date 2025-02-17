using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntContractsH
{
    public Guid ContractId { get; set; }

    public int ContractCode { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public int? ActivitiesId { get; set; }

    public int? RentalMonthes { get; set; }

    public int? InsuranceMonthes { get; set; }

    public int? ContractMonthes { get; set; }

    public DateTime? ContractStartDate { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public DateTime? IncreasingDate { get; set; }

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

    public virtual RntActivity Activities { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual CustomerDatum CustomerData { get; set; }

    public virtual ICollection<RntContractsD> RntContractsDs { get; set; } = new List<RntContractsD>();

    public virtual ICollection<RntReceiptsHeader> RntReceiptsHes { get; set; } = new List<RntReceiptsHeader>();
}
