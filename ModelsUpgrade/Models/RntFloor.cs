using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntFloor
{
    public Guid FloorId { get; set; }

    public int FloorsCode { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string FloorsNameL1 { get; set; }

    public string FloorsNameL2 { get; set; }

    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

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

    public virtual ICollection<RntFloor> InverseParentCodeNavigation { get; set; } = new List<RntFloor>();

    public virtual RntFloor ParentCodeNavigation { get; set; }

    public virtual ICollection<RntContractsD> RntContractsDs { get; set; } = new List<RntContractsD>();
}
