using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PosSale
{
    public Guid InvoiceId { get; set; }

    public long InvoiceNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? BarcodeInvoice { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public Guid? CustomerDataId { get; set; }

    public long? PriceTypeId { get; set; }

    public double? TotalValue { get; set; }

    public double? TotalDiscounts { get; set; }

    public double? TaxTotals { get; set; }

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

    public virtual BranchesData BranchesData { get; set; }

    public virtual CustomerDatum CustomerData { get; set; }

    public virtual ICollection<PospaymentDaily> PospaymentDailies { get; set; } = new List<PospaymentDaily>();

    public virtual ICollection<PossalesDetail> PossalesDetails { get; set; } = new List<PossalesDetail>();

    public virtual PriceType PriceType { get; set; }
}
