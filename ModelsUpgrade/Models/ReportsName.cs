using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ReportsName
{
    public long ReportId { get; set; }

    public long? ApplicationMenuId { get; set; }

    public string ReportNameL1 { get; set; }

    public string ReportNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ApplicationMenu ApplicationMenu { get; set; }
}
