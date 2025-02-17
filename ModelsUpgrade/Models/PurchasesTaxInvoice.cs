using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PurchasesTaxInvoice
{
    public Guid TaxInvoiceId { get; set; }

    public Guid? InvoicePurchasesFooterId { get; set; }

    public Guid? ReturnPurchasesFooterId { get; set; }

    public long? TaxableTypeId { get; set; }

    public double? TaxAmount { get; set; }

    public virtual PurchasesInvoiceFooter InvoicePurchasesFooter { get; set; }

    public virtual ReturnPurchasesFooter ReturnPurchasesFooter { get; set; }

    public virtual TaxableType TaxableType { get; set; }
}
