
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.Inventory.ItemsBalanceValueObjs;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Inventory
{
    public class ItemsBalanceFooter : FooterEntity
    {


        public Guid? ItemsBalanceHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }
        public Guid? UnitTypeId { get; set; }
        public ItemsBalanceCodeInfo ItemBalanceCodes { get; set; }

        public ItemsBalancePurchaseInfo ItemBalancePurchaseInfo { get; set; }

        public string Description { get; set; }


        public virtual ItemsBalanceHeader ItemsBalanceHeader { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual UnitType UnitType { get; set; }
    }
}
