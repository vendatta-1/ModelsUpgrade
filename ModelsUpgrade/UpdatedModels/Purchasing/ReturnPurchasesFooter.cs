using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class ReturnPurchasesFooter : Entity
    {
        public ReturnPurchasesFooter(Guid id) : base(id) { }
        protected ReturnPurchasesFooter()
        {

        }
        public Guid? ReturnPurchasesHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }

        public ObjectPricingDetails PricingDetails { get; set; }
        //public bool? IsPosted { get; set; }
        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual ICollection<PurchasesInvoiceDiscount> PurchasesInvoiceDiscounts { get; set; } = new HashSet<PurchasesInvoiceDiscount>();

        public virtual ICollection<PurchasesTaxInvoice> PurchasesTaxInvoices { get; set; } = new HashSet<PurchasesTaxInvoice>();

        public virtual ReturnPurchasesHeader ReturnPurchasesHeader { get; set; }

        public virtual UnitType UnitType { get; set; }

    }
}