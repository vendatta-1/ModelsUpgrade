
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class SalesInvoiceFooter : FooterEntity
    {

        public SalesInvoiceFooter(Guid id) : base(id)
        {

        }
        protected SalesInvoiceFooter()
        {

        }
        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }

        public ObjectPricingDetails PricingDetails { get; set; }

        //public bool? IsPosted { get; set; }


        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual SalesInvoiceDiscount SalesInvoiceDiscount { get; set; }

        public virtual SalesInvoiceHeader SalesInvoiceHeader { get; set; }

        public virtual ICollection<SalesTaxInvoiceFooter> SalesTaxInvoiceFs { get; set; } = new HashSet<SalesTaxInvoiceFooter>();

        public virtual UnitType UnitType { get; set; }
    }
}
