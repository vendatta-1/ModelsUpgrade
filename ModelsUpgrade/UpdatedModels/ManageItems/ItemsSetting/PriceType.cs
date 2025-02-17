
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.POSCasher;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting
{
    public class PriceType : NamedEntity
    {
        public PriceType(Guid id) : base(id)
        {

        }
        protected PriceType()
        {

        }

        public virtual ICollection<ItemsPriceSale> ItemsPriceSales { get; set; } = new HashSet<ItemsPriceSale>();

        public virtual ICollection<PosSale> Possales { get; set; } = new HashSet<PosSale>();

        public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new HashSet<ReturnSalesHeader>();

        public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new HashSet<SalesInvoiceHeader>();

    }
}
