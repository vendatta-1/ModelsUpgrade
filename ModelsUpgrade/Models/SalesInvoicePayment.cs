using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class SalesInvoicePayment
{
    public Guid PaymentId { get; set; }

    public Guid? SalesInvoiceHeaderId { get; set; }

    public long? PaymentModesId { get; set; }

    public long? BankCodeId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? Balance { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual BankCode BankCode { get; set; }

    public virtual PaymentMode PaymentModes { get; set; }

    public virtual SalesInvoiceHeader SalesInvoiceHeader { get; set; }
}
