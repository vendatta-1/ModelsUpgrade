
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PReturnPurchasesFooter : FooterEntity
    {
        public Guid? PreturnPurchasesHeaderId { get; set; }

        public Guid? PitemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public ObjectPricingDetails PricingDetails { get; set; }
        //public bool? IsPosted { get; set; }
        public virtual PItemsHeader PItemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PItemsStocks { get; set; } = new HashSet<PItemsStock>();

        public virtual PReturnPurchasesHeader PReturnPurchasesHeader { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
