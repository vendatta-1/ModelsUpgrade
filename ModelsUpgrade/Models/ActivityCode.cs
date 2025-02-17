using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ActivityCode
{
    public long ActivityCodeId { get; set; }

    public int? CodeTax { get; set; }

    public string ActivityCodeNameL1 { get; set; }

    public string ActivityCodeNameL2 { get; set; }

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

    public virtual ICollection<CompanyData> CompanyData { get; set; } = new List<CompanyData>();
}
