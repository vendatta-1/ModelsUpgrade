using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AccountsBalanceFooter
{
    public Guid AccountsBalanceFooterId { get; set; }

    public Guid? AccountsBalanceHeaderId { get; set; }

    public long? AccountFicationId { get; set; }

    public long? AccountNatureId { get; set; }

    public Guid? AccountNameId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountFication AccountFication { get; set; }

    public virtual AccountName AccountName { get; set; }

    public virtual AccountsBalanceHeader AccountsBalanceHeader { get; set; }
}
