using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesInvoicesDelivery
{
    public int InvoiceNo { get; set; }

    public DateOnly? Date { get; set; }

    public string CustomerName { get; set; }

    public string CustomerMobil { get; set; }

    public string DeliveryNameL1 { get; set; }

    public string DateValidity { get; set; }

    public double? DeliveryValue { get; set; }
}
