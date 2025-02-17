using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsHeader
{
    public Guid ItemHeaderId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? ItemsGroupsId { get; set; }

    public Guid? SupplierDataId { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public string InternationalBarCode { get; set; }

    public string SupplierBarCode { get; set; }

    public string InternalCode { get; set; }

    public long? ItemsTypeId { get; set; }

    public long? ItemsCodeTypeId { get; set; }

    public int? StockLimit { get; set; }

    public double? ItemPricePurchase { get; set; }

    public double? ItemPriceCost { get; set; }

    public double? ItemProfit1 { get; set; }

    public double? ItemPrice1 { get; set; }

    public double? ItemPrice2 { get; set; }

    public double? ItemPrice3 { get; set; }

    public double? ItemPrice4 { get; set; }

    public double? ItemPrice5 { get; set; }

    public long? UnitTypeId { get; set; }

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

    public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new List<AdditionAdjustment>();

    public virtual ICollection<InventoryOrderFooter> InventoryOrderFooters { get; set; } = new List<InventoryOrderFooter>();

    public virtual ICollection<ItemsBalanceFooter> ItemsBalanceFooters { get; set; } = new List<ItemsBalanceFooter>();

    public virtual ItemsCodeType ItemsCodeType { get; set; }

    public virtual ICollection<ItemsColor> ItemsColors { get; set; } = new List<ItemsColor>();

    public virtual ItemsGroup ItemsGroups { get; set; }

    public virtual ICollection<ItemsPricePurchase> ItemsPricePurchases { get; set; } = new List<ItemsPricePurchase>();

    public virtual ICollection<ItemsPriceSale> ItemsPriceSales { get; set; } = new List<ItemsPriceSale>();

    public virtual ICollection<ItemsProduction> ItemsProductions { get; set; } = new List<ItemsProduction>();

    public virtual ICollection<ItemsSize> ItemsSizes { get; set; } = new List<ItemsSize>();

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual ItemsType ItemsType { get; set; }

    public virtual ICollection<PossalesDetail> PossalesDetails { get; set; } = new List<PossalesDetail>();

    public virtual ICollection<PsettlementDiscount> PsettlementDiscounts { get; set; } = new List<PsettlementDiscount>();

    public virtual ICollection<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; } = new List<PurchasesInvoiceFooter>();

    public virtual ICollection<PurchasesOrderFooter> PurchasesOrderFooters { get; set; } = new List<PurchasesOrderFooter>();

    public virtual ICollection<RequestReceiptFooter> RequestReceiptFooters { get; set; } = new List<RequestReceiptFooter>();

    public virtual ICollection<RequestReservationFooter> RequestReservationFooters { get; set; } = new List<RequestReservationFooter>();

    public virtual ICollection<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; } = new List<ReturnPurchasesFooter>();

    public virtual ICollection<ReturnSalesFooter> ReturnSalesFooters { get; set; } = new List<ReturnSalesFooter>();

    public virtual ICollection<SalesInvoiceFooter> SalesInvoiceFooters { get; set; } = new List<SalesInvoiceFooter>();

    public virtual ICollection<SalesTaxInvoiceF> SalesTaxInvoiceFs { get; set; } = new List<SalesTaxInvoiceF>();

    public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new List<SettlementDiscount>();

    public virtual SupplierData SupplierData { get; set; }

    public virtual ICollection<TransformationsDetail> TransformationsDetails { get; set; } = new List<TransformationsDetail>();

    public virtual UnitType UnitType { get; set; }
}
