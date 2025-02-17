using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Inventory
{
    public class InventoryOrderFooter : FooterEntity
    {
        public InventoryOrderFooter(Guid id) : base(id)
        {

        }
        protected InventoryOrderFooter() { }

        public Guid? InventoryOrderHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }
        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo OrderDetails { get; set; }
        public virtual InventoryOrderHeader InventoryOrderHeader { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual UnitType UnitType { get; set; }



    }
}
