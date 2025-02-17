using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PPurchasesInvoiceFooter
{
    public Guid PpurchasesInvoiceFooterId { get; set; }

    public Guid? PpurchasesInvoiceHeaderId { get; set; }

    public Guid? PitemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? UnitPrice { get; set; }

    public double? Quantity { get; set; }

    public double? ItemValue { get; set; }

    public double? DiscountValue { get; set; }

    public double? ValueAfterDiscount { get; set; }

    public double? TaxValue { get; set; }

    public double? ItemNetValue { get; set; }

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

    public virtual PItemsHeader PitemsHeader { get; set; }

    public virtual PpurchasesInvoiceHeader PpurchasesInvoiceHeader { get; set; }

    public virtual UnitType UnitType { get; set; }
}
