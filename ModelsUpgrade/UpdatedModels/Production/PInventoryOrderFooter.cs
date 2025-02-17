
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PInventoryOrderFooter : FooterEntity
    {
        public Guid? PInventoryHeaderId { get; set; }
        public Guid? PPurchaseOrderHeaderId { get; set; }

        public Guid? PItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo TransactionInfo { get; set; }
        public virtual BranchesData BranchesData { get; set; }

        public virtual PItemsHeader PitemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new HashSet<PItemsStock>();

        public virtual StoreData StoreData { get; set; }

        public virtual UnitType UnitType { get; set; }
        public virtual PInventoryOrderHeader InventoryOrderHeader { get; set; }

    }
}
