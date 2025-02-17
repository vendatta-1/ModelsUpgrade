using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class InvoicingResult
{
    public long InvoicingResultId { get; set; }

    public string Uuid { get; set; }

    public string LongId { get; set; }

    public string InternalId { get; set; }

    public string HashKey { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
