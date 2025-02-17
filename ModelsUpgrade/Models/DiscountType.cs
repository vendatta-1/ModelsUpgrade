using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class DiscountType
{
    public long DiscountId { get; set; }

    public string DiscountNameL1 { get; set; }

    public string DiscountNameL2 { get; set; }

    public double? DiscountValue { get; set; }

    public double? DiscountPercent { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<PurchasesInvoiceDiscount> PurchasesInvoiceDiscounts { get; set; } = new List<PurchasesInvoiceDiscount>();

    public virtual ICollection<SalesInvoiceDiscount> SalesInvoiceDiscounts { get; set; } = new List<SalesInvoiceDiscount>();
}
