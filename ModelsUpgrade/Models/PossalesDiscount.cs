using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PossalesDiscount
{
    public Guid DiscountId { get; set; }

    public Guid? PossalesDetailsId { get; set; }

    public Guid? PosreturnSalesFooterId { get; set; }

    public long? DiscountTypeId { get; set; }

    public double? DiscountRate { get; set; }

    public double? DiscountAmount { get; set; }

    public virtual PossalesDetail PossalesDetails { get; set; }
}
