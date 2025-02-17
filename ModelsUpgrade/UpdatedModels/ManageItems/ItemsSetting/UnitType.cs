
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Contractors;
using ModelsUpgrade.UpdatedModels.Inventory;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.RealEstate;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting
{
    public class UnitType : NamedEntity
    {
        [MaxLength(5)]
        public string CodeTax { get; set; }
        public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new HashSet<AdditionAdjustment>();

        public virtual ICollection<ConContractorExtractDetail> ConContractorExtractDetails { get; set; } = new HashSet<ConContractorExtractDetail>();

        public virtual ICollection<InventoryOrderFooter> InventoryOrderFooters { get; set; } = new HashSet<InventoryOrderFooter>();

        public virtual ICollection<ItemsBalanceFooter> ItemsBalanceFooters { get; set; } = new HashSet<ItemsBalanceFooter>();

        public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new HashSet<ItemsHeader>();

        public virtual ICollection<ItemsPriceSale> ItemsPriceSales { get; set; } = new HashSet<ItemsPriceSale>();

        public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new HashSet<PAdditionAdjustment>();

        public virtual ICollection<PInventoryOrderFooter> PInventoryOrderFooters { get; set; } = new HashSet<PInventoryOrderFooter>();

        public virtual ICollection<PItemsBalanceFooter> PItemsBalanceFooters { get; set; } = new HashSet<PItemsBalanceFooter>();

        public virtual ICollection<PPurchasesInvoiceFooter> PPurchasesInvoiceFooters { get; set; } = new HashSet<PPurchasesInvoiceFooter>();

        public virtual ICollection<PRequestReceiptFooter> PRequestReceiptFooters { get; set; } = new HashSet<PRequestReceiptFooter>();

        public virtual ICollection<PRequestReservationFooter> PRequestReservationFooters { get; set; } = new HashSet<PRequestReservationFooter>();

        public virtual ICollection<PReturnPurchasesFooter> PReturnPurchasesFooters { get; set; } = new HashSet<PReturnPurchasesFooter>();

        public virtual ICollection<PReturnReservationFooter> PReturnReservationFooters { get; set; } = new HashSet<PReturnReservationFooter>();

        public virtual ICollection<PSettlementDiscount> PRSettlementDiscounts { get; set; } = new HashSet<PSettlementDiscount>();

        public virtual ICollection<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; } = new HashSet<PurchasesInvoiceFooter>();

        public virtual ICollection<PurchasesOrderFooter> PurchasesOrderFooters { get; set; } = new HashSet<PurchasesOrderFooter>();

        public virtual ICollection<RequestReceiptFooter> RequestReceiptFooters { get; set; } = new HashSet<RequestReceiptFooter>();

        public virtual ICollection<RequestReservationFooter> RequestReservationFooters { get; set; } = new HashSet<RequestReservationFooter>();

        public virtual ICollection<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; } = new HashSet<ReturnPurchasesFooter>();

        public virtual ICollection<ReturnSalesFooter> ReturnSalesFooters { get; set; } = new HashSet<ReturnSalesFooter>();

        public virtual ICollection<RntContractsData> RntContractsDatas { get; set; } = new HashSet<RntContractsData>();

        public virtual ICollection<SalesInvoiceFooter> SalesInvoiceFooters { get; set; } = new HashSet<SalesInvoiceFooter>();

        public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new HashSet<SettlementDiscount>();

        public virtual ICollection<TransformationsDetail> TransformationsDetails { get; set; } = new HashSet<TransformationsDetail>();
    }
}
