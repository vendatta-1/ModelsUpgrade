using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ApplicationMenu
{
    public long MenuId { get; set; }

    public long? MenuUd { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string MenuNameL1 { get; set; }

    public string MenuNameL2 { get; set; }

    public long? ParentCode { get; set; }

    public int? LevelCode { get; set; }

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

    public virtual ICollection<AspPermission> AspPermissions { get; set; } = new List<AspPermission>();

    public virtual BranchesData BranchesData { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ProgramOption> ProgramOptions { get; set; } = new List<ProgramOption>();

    public virtual ICollection<ReportsName> ReportsNames { get; set; } = new List<ReportsName>();
}
