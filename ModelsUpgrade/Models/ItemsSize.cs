using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsSize
{
    public Guid ItemsSizeId { get; set; }

    public Guid? ItemHeaderId { get; set; }

    public long? SizeTypeId { get; set; }

    public double? SizeValue { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public string Modifiedby { get; set; }

    public virtual ItemsHeader ItemHeader { get; set; }

    public virtual SizeType SizeType { get; set; }
}
