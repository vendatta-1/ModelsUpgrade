using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SizeType
{
    public long SizeId { get; set; }

    public string SizenameL1 { get; set; }

    public string SizenameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<ItemsColor> ItemsColors { get; set; } = new List<ItemsColor>();

    public virtual ICollection<ItemsSize> ItemsSizes { get; set; } = new List<ItemsSize>();
}
