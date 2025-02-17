using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CostJournalFooter
{
    public Guid JournalFooterId { get; set; }

    public Guid? JournalHeaderId { get; set; }

    public Guid? AccountNameId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

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

    public virtual CostCenter AccountName { get; set; }

    public virtual CostJournalHeader JournalHeader { get; set; }
}
