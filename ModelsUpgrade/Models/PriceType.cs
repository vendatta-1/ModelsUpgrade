namespace Link_Entities.Models;

public partial class PriceType
{
    public long PriceId { get; set; }

    public string PriceNameL1 { get; set; }

    public string PriceNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<ItemsPriceSale> ItemsPriceSales { get; set; } = new List<ItemsPriceSale>();

    public virtual ICollection<PosSale> Possales { get; set; } = new List<PosSale>();

    public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new List<ReturnSalesHeader>();

    public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new List<SalesInvoiceHeader>();
}
