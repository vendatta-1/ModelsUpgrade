using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PossalesDetail
{
    public Guid InvoiceDetailsId { get; set; }

    public Guid? PossalesId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? UnitPrice { get; set; }

    public double? Quantity { get; set; }

    public double? ItemValue { get; set; }

    public double? DiscountValue { get; set; }

    public double? ValueAfterDiscount { get; set; }

    public double? TaxValue { get; set; }

    public double? NetValue { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual PosSale Possales { get; set; }

    public virtual ICollection<PossalesDiscount> PossalesDiscounts { get; set; } = new List<PossalesDiscount>();
}
