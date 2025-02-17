using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesTaxInvoiceF
{
    public Guid TaxInvoiceId { get; set; }

    public Guid? SalesInvoiceFooterId { get; set; }

    public Guid? ReturnSalesFooterId { get; set; }

    public long? TaxableTypeId { get; set; }

    public double? TaxAmount { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual ReturnSalesFooter ReturnSalesFooter { get; set; }

    public virtual SalesInvoiceFooter SalesInvoiceFooter { get; set; }

    public virtual TaxableType TaxableType { get; set; }
}
