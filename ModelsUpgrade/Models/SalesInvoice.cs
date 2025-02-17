using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesInvoice
{
    public string BranchName { get; set; }

    public int InvoiceNo { get; set; }

    public string ItemNameL1 { get; set; }

    public string UnitNameL1 { get; set; }

    public double? UnitPrice { get; set; }

    public double? Quantity { get; set; }

    public double? ItemValue { get; set; }

    public double? DiscountValue { get; set; }

    public double? ValueAfterDiscount { get; set; }

    public double? TaxValue { get; set; }

    public double? NetValue { get; set; }

    public DateOnly? Date { get; set; }

    public string PriceNameL1 { get; set; }

    public double? TotalValue { get; set; }

    public double? TotalDiscounts { get; set; }

    public double? TaxTotals { get; set; }

    public double? NetValues { get; set; }

    public double? TaxAmount { get; set; }

    public string TaxNameL1 { get; set; }

    public double? Expr1 { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? Balance { get; set; }

    public string PaymentNameL1 { get; set; }

    public string DateValidity { get; set; }

    public string DeliveryNameL1 { get; set; }

    public double? DeliveryValue { get; set; }
}
