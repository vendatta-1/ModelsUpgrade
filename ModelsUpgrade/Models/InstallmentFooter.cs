using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class InstallmentFooter
{
    public long InstallmentFooterId { get; set; }

    public long? InstallmentHeaderId { get; set; }

    public DateOnly? InstallmentDate { get; set; }

    public double? InstallmentValue { get; set; }

    public int? InstallmentNumber { get; set; }

    public bool? PostedInstallment { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual InstallmentHeader InstallmentHeader { get; set; }
}
