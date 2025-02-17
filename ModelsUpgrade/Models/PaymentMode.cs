using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PaymentMode
{
    public long PaymentId { get; set; }

    public string CodeTax { get; set; }

    public string PaymentNameL1 { get; set; }

    public string PaymentNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EmployeeDatum> EmployeeData { get; set; } = new List<EmployeeDatum>();

    public virtual ICollection<PospaymentDaily> PospaymentDailies { get; set; } = new List<PospaymentDaily>();

    public virtual ICollection<PreturnPurchasesHeader> PreturnPurchasesHeaders { get; set; } = new List<PreturnPurchasesHeader>();

    public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new List<PurchasesInvoiceHeader>();

    public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new List<ReturnPurchasesHeader>();

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new List<ReturnSalesHeader>();

    public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new List<SalesInvoiceHeader>();

    public virtual ICollection<SalesInvoicePayment> SalesInvoicePayments { get; set; } = new List<SalesInvoicePayment>();
}
