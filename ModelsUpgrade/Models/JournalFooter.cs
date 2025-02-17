using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class JournalFooter
{
    public Guid JournalFooterId { get; set; }

    public Guid? JournalHeaderId { get; set; }

    public Guid? AccountNameId { get; set; }

    public Guid? CostCenterId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? Balance { get; set; }

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

    public virtual AccountName AccountName { get; set; }

    public virtual CostCenter CostCenter { get; set; }

    public virtual JournalHeader JournalHeader { get; set; }
}
