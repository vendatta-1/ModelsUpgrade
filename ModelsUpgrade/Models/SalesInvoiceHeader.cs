namespace Link_Entities.Models;

public partial class SalesInvoiceHeader
{
    public Guid InvoiceSalesHeaderId { get; set; }

    public int InvoiceNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? RequestReservationHeaderId { get; set; }

    public string BarcodeInvoice { get; set; }

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

    public double? TotalAfterDiscounts { get; set; }

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

    public virtual PaymentMode PaymentModes { get; set; }

    public virtual PriceType PriceType { get; set; }

    public virtual RequestReservationHeader RequestReservationHeader { get; set; }

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new List<ReturnSalesHeader>();

    public virtual ICollection<SalesInvoiceDelivery> SalesInvoiceDeliveries { get; set; } = new List<SalesInvoiceDelivery>();

    public virtual ICollection<SalesInvoiceFooter> SalesInvoiceFooters { get; set; } = new List<SalesInvoiceFooter>();

    public virtual ICollection<SalesInvoicePayment> SalesInvoicePayments { get; set; } = new List<SalesInvoicePayment>();

    public virtual ICollection<SalesTaxInvoiceH> SalesTaxInvoiceHs { get; set; } = new List<SalesTaxInvoiceH>();
}
