
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PPurchasesInvoiceFooter : FooterEntity
    {
        public Guid? PPurchasesInvoiceHeaderId { get; set; }

        public Guid? PItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }

        public ObjectPricingDetails PricingDetails { get; set; }
        public double? ItemNetValue { get; set; }
        //public bool? IsPosted { get; set; }
        public virtual PItemsHeader PItemsHeader { get; set; }

        public virtual PPurchasesInvoiceHeader PPurchasesInvoiceHeader { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
