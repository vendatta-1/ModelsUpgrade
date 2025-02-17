using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntReceiptsD
{
    public Guid ReceiptId { get; set; }

    public Guid? ReceiptH { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public double? DueValue { get; set; }

    public double? PaidValue { get; set; }

    public double? RemainingValue { get; set; }

    public double? DiscountValue { get; set; }

    public double? NetValue { get; set; }

    public string ReciptNo { get; set; }

    public string Description { get; set; }

    public virtual RntReceiptsHeader ReceiptHNavigation { get; set; }
}
