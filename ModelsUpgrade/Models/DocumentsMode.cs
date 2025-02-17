using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class DocumentsMode
{
    public long DocumentId { get; set; }

    public string DocumentType { get; set; }

    public string DocumentTypeVersion { get; set; }

    public string DocumentTypeName { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<PreturnPurchasesHeader> PreturnPurchasesHeaders { get; set; } = new List<PreturnPurchasesHeader>();

    public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new List<PurchasesInvoiceHeader>();

    public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new List<ReturnPurchasesHeader>();

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new List<ReturnSalesHeader>();

    public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new List<SalesInvoiceHeader>();
}
