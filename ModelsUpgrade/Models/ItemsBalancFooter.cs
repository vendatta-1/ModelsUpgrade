using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsBalancFooter
{
    public int ItemsBalanceHeaderId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string BalanceNameL1 { get; set; }

    public string StoreName { get; set; }

    public string Description { get; set; }

    public string InternalCode { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public string UnitNameL1 { get; set; }

    public double? ItemQuantity { get; set; }

    public double? ItemPrice { get; set; }

    public double? ItemValue { get; set; }

    public double? TotalValue { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? Expr1 { get; set; }

    public bool? Expr2 { get; set; }
}
