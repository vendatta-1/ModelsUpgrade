using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class DatabaseDescription
{
    public int Id { get; set; }

    public string NameL1 { get; set; }

    public string NameL2 { get; set; }

    public string ShortName { get; set; }

    public int? ParentCode { get; set; }

    public int? LeavelCode { get; set; }

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

    public virtual ICollection<DatabaseDescription> InverseParentCodeNavigation { get; set; } = new List<DatabaseDescription>();

    public virtual DatabaseDescription ParentCodeNavigation { get; set; }
}
