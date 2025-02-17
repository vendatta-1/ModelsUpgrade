
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class ReturnSalesFooter : FooterEntity
    {
        public ReturnSalesFooter(Guid id) : base(id) { }

        protected ReturnSalesFooter()
        {

        }
        public Guid? ReturnSalesHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public ObjectPricingDetails PricingDetails { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual ReturnSalesHeader ReturnSalesHeader { get; set; }

        public virtual ICollection<SalesInvoiceDiscount> SalesInvoiceDiscounts { get; set; } = new HashSet<SalesInvoiceDiscount>();

        public virtual ICollection<SalesTaxInvoiceFooter> SalesTaxInvoiceFs { get; set; } = new HashSet<SalesTaxInvoiceFooter>();

        public virtual UnitType UnitType { get; set; }
    }
}
