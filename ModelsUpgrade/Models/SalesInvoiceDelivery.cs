using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesInvoiceDelivery
{
    public Guid DeliveryId { get; set; }

    public Guid? InvoiceSalesHeaderId { get; set; }

    public long? DeliveryModesId { get; set; }

    public string Approach { get; set; }

    public string Packaging { get; set; }

    public string DateValidity { get; set; }

    public string ExportPort { get; set; }

    public string CountryOfOriginId { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? NetWeight { get; set; }

    public string Terms { get; set; }

    public double? DeliveryValue { get; set; }

    public virtual DeliveryMode DeliveryModes { get; set; }

    public virtual SalesInvoiceHeader InvoiceSalesHeader { get; set; }
}
