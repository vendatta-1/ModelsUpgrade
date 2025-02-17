using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PurchasesInvoiceDiscount
{
    public Guid DiscountInvoiceId { get; set; }

    public Guid? PurchasesInvoiceFooterId { get; set; }

    public Guid? ReturnPurchasesFooterId { get; set; }

    public long? DiscountTypeId { get; set; }

    public double? DiscountRate { get; set; }

    public double? DiscountAmount { get; set; }

    public virtual DiscountType DiscountType { get; set; }

    public virtual PurchasesInvoiceFooter PurchasesInvoiceFooter { get; set; }

    public virtual ReturnPurchasesFooter ReturnPurchasesFooter { get; set; }
}
