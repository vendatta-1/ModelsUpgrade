using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsPriceSalesMenu
{
    public string InternalCode { get; set; }

    public string ItemNameL1 { get; set; }

    public string PriceNameL1 { get; set; }

    public string UnitNameL1 { get; set; }

    public DateTime? DateSales { get; set; }

    public double? PriceValue { get; set; }
}
