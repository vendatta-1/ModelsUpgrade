using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesTaxInvoiceH
{
    public Guid TaxInvoiceId { get; set; }

    public Guid? SalesInvoiceHeaderId { get; set; }

    public Guid? ReturnSalesHeaderId { get; set; }

    public long? TaxableTypeId { get; set; }

    public double? TaxAmount { get; set; }

    public virtual ReturnSalesHeader ReturnSalesHeader { get; set; }

    public virtual SalesInvoiceHeader SalesInvoiceHeader { get; set; }

    public virtual TaxableType TaxableType { get; set; }
}
