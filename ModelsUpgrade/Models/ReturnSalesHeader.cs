namespace Link_Entities.Models;

public partial class ReturnSalesHeader
{
    public Guid ReturnSalesHeaderId { get; set; }

    public long ReturnNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? InvoiceSalesHeaderId { get; set; }

    public string BarcodeReturn { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public Guid? CustomerDataId { get; set; }

    public long? DocumentsModesId { get; set; }

    public long? PriceTypeId { get; set; }

    public long? PaymentModesId { get; set; }

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

    public virtual DocumentsMode DocumentsModes { get; set; }

    public virtual SalesInvoiceHeader InvoiceSalesHeader { get; set; }

    public virtual PaymentMode PaymentModes { get; set; }

    public virtual PriceType PriceType { get; set; }

    public virtual ICollection<ReturnSalesFooter> ReturnSalesFooters { get; set; } = new List<ReturnSalesFooter>();

    public virtual ICollection<SalesTaxInvoiceH> SalesTaxInvoiceHs { get; set; } = new List<SalesTaxInvoiceH>();
}
