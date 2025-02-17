using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class PurchasesOrderFooter : FooterEntity
    {
        public PurchasesOrderFooter(Guid id) : base(id)
        {

        }
        protected PurchasesOrderFooter()
        {

        }
        public Guid OrderId { get; set; }

        public Guid? PurchaseOrderHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }

        public PurchaseInfo PurchaseInfo { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual PurchasesOrderHeader PurchaseOrderHeader { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
