
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PRequestReceiptFooter : FooterEntity
    {
        public Guid? PRequestReceiptHeaderId { get; set; }

        public Guid? PItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        //public bool? IsPosted { get; set; }
        public virtual PItemsHeader PItemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PItemsStocks { get; set; } = new HashSet<PItemsStock>();

        public virtual PRequestReceiptHeader PRequestReceiptHeader { get; set; }

        public virtual UnitType UnitType { get; set; }

    }
}
