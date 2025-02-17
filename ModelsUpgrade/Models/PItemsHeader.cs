namespace Link_Entities.Models;

public partial class PItemsHeader
{
    public Guid ItemHeaderId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? PitemsGroupsId { get; set; }

    public Guid? SupplierDataId { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public string InternalCode { get; set; }

    public long? ItemsTypeId { get; set; }

    public long? ItemsCodeTypeId { get; set; }

    public int? StockLimit { get; set; }

    public Guid? AccountsNamePurchasId { get; set; }

    public Guid? AccountNameSalesId { get; set; }

    public bool? IsNotActiveTax { get; set; }

    public bool? IsNotActiveTaxDiscount { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string ImageUrl { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountName AccountNameSales { get; set; }

    public virtual AccountName AccountsNamePurchas { get; set; }

    public virtual ItemsType ItemsType { get; set; }

    public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new List<PAdditionAdjustment>();

    public virtual ICollection<PInventoryOrderFooter> PinventoryOrderFooters { get; set; } = new List<PInventoryOrderFooter>();

    public virtual ICollection<PItemsBalanceFooter> PitemsBalanceFooters { get; set; } = new List<PItemsBalanceFooter>();

    public virtual PItemsGroup PitemsGroups { get; set; }

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new List<PItemsStock>();

    public virtual ICollection<PPurchasesInvoiceFooter> PpurchasesInvoiceFooters { get; set; } = new List<PPurchasesInvoiceFooter>();

    public virtual ICollection<PRequestReceiptFooter> PrequestReceiptFooters { get; set; } = new List<PRequestReceiptFooter>();

    public virtual ICollection<PRequestReservationFooter> PrequestReservationFooters { get; set; } = new List<PRequestReservationFooter>();

    public virtual ICollection<PReturnPurchasesFooter> PreturnPurchasesFooters { get; set; } = new List<PReturnPurchasesFooter>();

    public virtual ICollection<PReturnReservationFooter> PreturnReservationFooters { get; set; } = new List<PReturnReservationFooter>();

    public virtual SupplierData SupplierData { get; set; }
}
