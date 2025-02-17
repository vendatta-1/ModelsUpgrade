using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AspPermission
{
    public long PermissionId { get; set; }

    public string AspNetUsersId { get; set; }

    public long? ApplicationMenuId { get; set; }

    public bool? OpenForm { get; set; }

    public bool? AddForm { get; set; }

    public bool? EditForm { get; set; }

    public bool? DeleteForm { get; set; }

    public bool? ReadForm { get; set; }

    public bool? SearchForm { get; set; }

    public bool? FilterForm { get; set; }

    public bool? PrinterReport { get; set; }

    public bool? ExportFile { get; set; }

    public bool? ExportDataGrid { get; set; }

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

    public virtual AspNetUser AspNetUsers { get; set; }
}
