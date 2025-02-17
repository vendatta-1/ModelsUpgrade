
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PItemsBalanceHeader : HeaderEntity
    {


        public DateInfo DateInfo { get; set; }

        public Guid? BalanceNameId { get; set; }

        public Guid? StoreDataId { get; set; }
        public double? TotalValue { get; set; } = 0;


        public virtual ICollection<PItemsBalanceFooter> PItemsBalanceFooters { get; set; } = new HashSet<PItemsBalanceFooter>();

        public virtual StoreData StoreData { get; set; }

    }
}
