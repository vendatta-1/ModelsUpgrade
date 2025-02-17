using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsColor
{
    public Guid ItemsColorId { get; set; }

    public Guid? ItemHeaderId { get; set; }

    public long? SizeTypeId { get; set; }

    public long? ColorTypeId { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public string Modifiedby { get; set; }

    public virtual ColorType ColorType { get; set; }

    public virtual ItemsHeader ItemHeader { get; set; }

    public virtual SizeType SizeType { get; set; }
}
