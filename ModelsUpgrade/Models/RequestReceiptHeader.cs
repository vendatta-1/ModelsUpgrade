using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RequestReceiptHeader
{
    public Guid RequestReceiptHeaderId { get; set; }

    public int RequestReceiptNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? PurchaseOrderHeaderId { get; set; }

    public Guid? StoreDataId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public double? TotalValue { get; set; }

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

    public virtual BranchesData BranchesData { get; set; }

    public virtual InventoryOrderHeader PurchaseOrderHeader { get; set; }

    public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new List<PurchasesInvoiceHeader>();

    public virtual ICollection<RequestReceiptFooter> RequestReceiptFooters { get; set; } = new List<RequestReceiptFooter>();

    public virtual StoreData StoreData { get; set; }
}
