using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class TaxableType
{
    public long TaxId { get; set; }

    public string TaxNameL1 { get; set; }

    public string TaxNameL2 { get; set; }

    public string TaxTable { get; set; }

    public string TaxCode { get; set; }

    public double? TaxPercent { get; set; }

    public long? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<TaxableType> InverseParentCodeNavigation { get; set; } = new List<TaxableType>();

    public virtual TaxableType ParentCodeNavigation { get; set; }

    public virtual ICollection<PurchasesTaxInvoice> PurchasesTaxInvoices { get; set; } = new List<PurchasesTaxInvoice>();

    public virtual ICollection<SalesTaxInvoiceF> SalesTaxInvoiceFs { get; set; } = new List<SalesTaxInvoiceF>();

    public virtual ICollection<SalesTaxInvoiceH> SalesTaxInvoiceHs { get; set; } = new List<SalesTaxInvoiceH>();
}
