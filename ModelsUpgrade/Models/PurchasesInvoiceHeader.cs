namespace Link_Entities.Models;

public partial class PurchasesInvoiceHeader
{
    public Guid PurchasesInvoiceHeaderId { get; set; }

    public int InvoiceNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? RequestReceiptHeaderid { get; set; }

    public string BarcodeInvoice { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public Guid? SuppliersDataid { get; set; }

    public long? DocumentsModesId { get; set; }

    public long? PaymentModesId { get; set; }

    public double? TotalValue { get; set; }

    public double? TotalDiscounts { get; set; }

    public double? TotalAfterDiscounts { get; set; }

    public double? TotalTaxs { get; set; }

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

    public virtual DocumentsMode DocumentsModes { get; set; }

    public virtual PaymentMode PaymentModes { get; set; }

    public virtual ICollection<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; } = new List<PurchasesInvoiceFooter>();

    public virtual RequestReceiptHeader RequestReceiptHeader { get; set; }

    public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new List<ReturnPurchasesHeader>();

    public virtual SupplierData SuppliersData { get; set; }
}
