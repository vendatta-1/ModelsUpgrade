using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class PurchasesInvoiceFooter : FooterEntity
    {
        public PurchasesInvoiceFooter(Guid id) : base(id)
        {

        }
        protected PurchasesInvoiceFooter()
        {

        }
        public Guid? PurchasesInvoiceHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }

        public ObjectPricingDetails PricingDetails { get; set; }


        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<PurchasesInvoiceDiscount> PurchasesInvoiceDiscounts { get; set; } = new HashSet<PurchasesInvoiceDiscount>();

        public virtual PurchasesInvoiceHeader PurchasesInvoiceHeader { get; set; }

        public virtual ICollection<PurchasesTaxInvoice> PurchasesTaxInvoices { get; set; } = new HashSet<PurchasesTaxInvoice>();

        public virtual UnitType UnitType { get; set; }
    }
}
