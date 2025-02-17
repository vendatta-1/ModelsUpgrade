using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesInvoiceFooter
{
    public Guid SalesInvoiceFooterId { get; set; }

    public Guid? SalesInvoiceHeaderId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? UnitPrice { get; set; }

    public double? Quantity { get; set; }

    public double? ItemValue { get; set; }

    public double? DiscountValue { get; set; }

    public double? ValueAfterDiscount { get; set; }

    public double? TaxValue { get; set; }

    public double? NetValue { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual SalesInvoiceDiscount SalesInvoiceDiscount { get; set; }

    public virtual SalesInvoiceHeader SalesInvoiceHeader { get; set; }

    public virtual ICollection<SalesTaxInvoiceF> SalesTaxInvoiceFs { get; set; } = new List<SalesTaxInvoiceF>();

    public virtual UnitType UnitType { get; set; }
}
