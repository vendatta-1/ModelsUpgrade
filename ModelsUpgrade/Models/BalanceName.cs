using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class BalanceName
{
    public long BalanceId { get; set; }

    public string BalanceNameL1 { get; set; }

    public string BalanceNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AccountsBalanceHeader> AccountsBalanceHeaders { get; set; } = new List<AccountsBalanceHeader>();

    public virtual ICollection<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; } = new List<ItemsBalanceHeader>();
}
