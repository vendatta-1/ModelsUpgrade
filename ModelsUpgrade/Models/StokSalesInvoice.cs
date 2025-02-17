using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class StokSalesInvoice
{
    public Guid? BranchesDataId { get; set; }

    public int InvoiceNo { get; set; }

    public DateOnly? Date { get; set; }

    public string CustomerName { get; set; }

    public string InternalCode { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public string UnitNameL1 { get; set; }

    public string UnitNameL2 { get; set; }

    public double? UnitPrice { get; set; }

    public double? Quantity { get; set; }

    public double? ItemValue { get; set; }
}
