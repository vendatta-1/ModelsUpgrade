

using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.Inventory;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsValueObjs;
using ModelsUpgrade.UpdatedModels.POSCasher;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.ManageItems
{
    public class ItemsHeader : NamedEntity
    {



        public Guid? CompanyDataId { get; set; }

        public Guid? ItemsGroupsId { get; set; }

        public Guid? SupplierDataId { get; set; }
        public ItemsCodeInfo ItemsCodeInfo { get; set; }

        public Guid? ItemsTypeId { get; set; }

        public Guid? ItemsCodeTypeId { get; set; }

        public ItemsPricingDetails PricingDetails { get; set; }
        public Guid? UnitTypeId { get; set; }

        public bool? IsNotActiveTax { get; set; }

        public bool? IsNotActiveTaxDiscount { get; set; }

        //public DateOnly? StartDate { get; set; }

        //public DateOnly? EndDate { get; set; }
        public Duration DurationInfo { get; set; }

        public string ImageUrl { get; set; }
        public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new HashSet<AdditionAdjustment>();

        public virtual ICollection<InventoryOrderFooter> InventoryOrderFooters { get; set; } = new HashSet<InventoryOrderFooter>();

        public virtual ICollection<ItemsBalanceFooter> ItemsBalanceFooters { get; set; } = new HashSet<ItemsBalanceFooter>();

        public virtual ItemsCodeType ItemsCodeType { get; set; }

        public virtual ICollection<ItemsColor> ItemsColors { get; set; } = new HashSet<ItemsColor>();

        public virtual ItemsGroup ItemsGroups { get; set; }

        public virtual ICollection<ItemsPricePurchase> ItemsPricePurchases { get; set; } = new HashSet<ItemsPricePurchase>();

        public virtual ICollection<ItemsPriceSale> ItemsPriceSales { get; set; } = new HashSet<ItemsPriceSale>();

        public virtual ICollection<ItemsProduction> ItemsProductions { get; set; } = new HashSet<ItemsProduction>();

        public virtual ICollection<ItemSize> ItemsSizes { get; set; } = new HashSet<ItemSize>();

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual ItemsType ItemsType { get; set; }

        public virtual ICollection<PosSalesDetail> PossalesDetails { get; set; } = new HashSet<PosSalesDetail>();

        public virtual ICollection<PSettlementDiscount> PsettlementDiscounts { get; set; } = new HashSet<PSettlementDiscount>();

        public virtual ICollection<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; } = new HashSet<PurchasesInvoiceFooter>();

        public virtual ICollection<PurchasesOrderFooter> PurchasesOrderFooters { get; set; } = new HashSet<PurchasesOrderFooter>();

        public virtual ICollection<RequestReceiptFooter> RequestReceiptFooters { get; set; } = new HashSet<RequestReceiptFooter>();

        public virtual ICollection<RequestReservationFooter> RequestReservationFooters { get; set; } = new HashSet<RequestReservationFooter>();

        public virtual ICollection<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; } = new HashSet<ReturnPurchasesFooter>();

        public virtual ICollection<ReturnSalesFooter> ReturnSalesFooters { get; set; } = new HashSet<ReturnSalesFooter>();

        public virtual ICollection<SalesInvoiceFooter> SalesInvoiceFooters { get; set; } = new HashSet<SalesInvoiceFooter>();

        public virtual ICollection<SalesTaxInvoiceFooter> SalesTaxInvoiceFs { get; set; } = new HashSet<SalesTaxInvoiceFooter>();

        public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new HashSet<SettlementDiscount>();

        public virtual SupplierData SupplierData { get; set; }

        public virtual ICollection<TransformationsDetail> TransformationsDetails { get; set; } = new HashSet<TransformationsDetail>();

        public virtual UnitType UnitType { get; set; }
        public virtual CompanyData CompanyData { get; set; }
    }
}
