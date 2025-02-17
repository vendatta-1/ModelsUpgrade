using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Inventory;

public class TransformationsDetail : Entity
{


    public Guid? TransformationsMasterId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public Guid? UnitTypeId { get; set; }
    public PurchaseInfo PurchaseInfo { get; set; }


    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual TransformationsMaster TransformationsMaster { get; set; }

    public virtual UnitType UnitType { get; set; }
}
