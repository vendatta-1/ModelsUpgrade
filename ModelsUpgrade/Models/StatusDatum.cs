using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class StatusDatum
{
    public long StatusId { get; set; }

    public string StatusNameL1 { get; set; }

    public string StatusNameL2 { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
