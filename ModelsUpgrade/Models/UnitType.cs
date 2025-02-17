namespace Link_Entities.Models;

public partial class UnitType
{
    public long UnitId { get; set; }

    public string CodeTax { get; set; }

    public string UnitNameL1 { get; set; }

    public string UnitNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new List<AdditionAdjustment>();

    public virtual ICollection<ConContractorExtractDetail> ConContractorExtractDetails { get; set; } = new List<ConContractorExtractDetail>();

    public virtual ICollection<InventoryOrderFooter> InventoryOrderFooters { get; set; } = new List<InventoryOrderFooter>();

    public virtual ICollection<ItemsBalanceFooter> ItemsBalanceFooters { get; set; } = new List<ItemsBalanceFooter>();

    public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new List<ItemsHeader>();

    public virtual ICollection<ItemsPriceSale> ItemsPriceSales { get; set; } = new List<ItemsPriceSale>();

    public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new List<PAdditionAdjustment>();

    public virtual ICollection<PInventoryOrderFooter> PinventoryOrderFooters { get; set; } = new List<PInventoryOrderFooter>();

    public virtual ICollection<PItemsBalanceFooter> PitemsBalanceFooters { get; set; } = new List<PItemsBalanceFooter>();

    public virtual ICollection<PPurchasesInvoiceFooter> PpurchasesInvoiceFooters { get; set; } = new List<PPurchasesInvoiceFooter>();

    public virtual ICollection<PRequestReceiptFooter> PrequestReceiptFooters { get; set; } = new List<PRequestReceiptFooter>();

    public virtual ICollection<PRequestReservationFooter> PrequestReservationFooters { get; set; } = new List<PRequestReservationFooter>();

    public virtual ICollection<PReturnPurchasesFooter> PreturnPurchasesFooters { get; set; } = new List<PReturnPurchasesFooter>();

    public virtual ICollection<PReturnReservationFooter> PreturnReservationFooters { get; set; } = new List<PReturnReservationFooter>();

    public virtual ICollection<PsettlementDiscount> PsettlementDiscounts { get; set; } = new List<PsettlementDiscount>();

    public virtual ICollection<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; } = new List<PurchasesInvoiceFooter>();

    public virtual ICollection<PurchasesOrderFooter> PurchasesOrderFooters { get; set; } = new List<PurchasesOrderFooter>();

    public virtual ICollection<RequestReceiptFooter> RequestReceiptFooters { get; set; } = new List<RequestReceiptFooter>();

    public virtual ICollection<RequestReservationFooter> RequestReservationFooters { get; set; } = new List<RequestReservationFooter>();

    public virtual ICollection<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; } = new List<ReturnPurchasesFooter>();

    public virtual ICollection<ReturnSalesFooter> ReturnSalesFooters { get; set; } = new List<ReturnSalesFooter>();

    public virtual ICollection<RntContractsD> RntContractsDs { get; set; } = new List<RntContractsD>();

    public virtual ICollection<SalesInvoiceFooter> SalesInvoiceFooters { get; set; } = new List<SalesInvoiceFooter>();

    public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new List<SettlementDiscount>();

    public virtual ICollection<TransformationsDetail> TransformationsDetails { get; set; } = new List<TransformationsDetail>();
}
