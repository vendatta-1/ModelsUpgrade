
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PAdditionAdjustment : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? StoreDataId { get; set; }

        public Guid? PItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo? TransactionInfo { get; set; }
        public virtual BranchesData BranchesData { get; set; }

        public virtual PItemsHeader PitemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PItemsStocks { get; set; } = new List<PItemsStock>();

        public virtual StoreData StoreData { get; set; }

        public virtual UnitType UnitType { get; set; }

    }
}
