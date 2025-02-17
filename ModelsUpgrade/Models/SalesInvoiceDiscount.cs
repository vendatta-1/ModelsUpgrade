using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesInvoiceDiscount
{
    public Guid DiscountInvoiceId { get; set; }

    public Guid? InvoiceSalesFooterId { get; set; }

    public Guid? ReturnSalesFooterId { get; set; }

    public long? DiscountTypeId { get; set; }

    public double? DiscountRate { get; set; }

    public double? DiscountAmount { get; set; }

    public virtual SalesInvoiceFooter DiscountInvoice { get; set; }

    public virtual DiscountType DiscountType { get; set; }

    public virtual ReturnSalesFooter ReturnSalesFooter { get; set; }
}
