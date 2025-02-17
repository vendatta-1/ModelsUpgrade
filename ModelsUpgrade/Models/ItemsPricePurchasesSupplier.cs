using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsPricePurchasesSupplier
{
    public string InternalCode { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public string SupplierName { get; set; }

    public DateTime? DatePurchases { get; set; }

    public double? ItemsPrice { get; set; }
}
