
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PItemsBalanceFooter : FooterEntity
    {
        public Guid? PItemsBalanceHeaderId { get; set; }

        public Guid? PItemsHeaderId { get; set; }
        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo? PurchaseInfo { get; set; }
        public virtual PItemsBalanceHeader PItemsBalanceHeader { get; set; }

        public virtual PItemsHeader PItemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new HashSet<PItemsStock>();

        public virtual UnitType UnitType { get; set; }
    }
}
