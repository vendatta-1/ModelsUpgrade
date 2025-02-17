namespace Link_Entities.Models;

public partial class ReturnPurchasesHeader
{
    public Guid ReturnPurchasesHeaderId { get; set; }

    public int ReturnNo { get; set; }

    public Guid? PurchasesInvoiceHeaderId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string BarcodeInvoice { get; set; }

    public Guid? SuppliersDataId { get; set; }

    public long? DocumentsModesId { get; set; }

    public long? PaymentModesId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public double? TotalValue { get; set; }

    public double? TotalDiscounts { get; set; }

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

    public virtual PurchasesInvoiceHeader PurchasesInvoiceHeader { get; set; }

    public virtual ICollection<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; } = new List<ReturnPurchasesFooter>();

    public virtual SupplierData SuppliersData { get; set; }
}
