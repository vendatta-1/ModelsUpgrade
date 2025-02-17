using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpLevelType
{
    public long LevelId { get; set; }

    public string LevelNameL1 { get; set; }

    public string LevelNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EmpLevel> EmpLevels { get; set; } = new List<EmpLevel>();
}
