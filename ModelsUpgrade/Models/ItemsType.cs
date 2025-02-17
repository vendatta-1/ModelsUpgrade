using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsType
{
    public long ItemsTypeId { get; set; }

    public string ItemsTypeNameL1 { get; set; }

    public string ItemsTypeNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new List<ItemsHeader>();

    public virtual ICollection<PItemsHeader> PitemsHeaders { get; set; } = new List<PItemsHeader>();
}
