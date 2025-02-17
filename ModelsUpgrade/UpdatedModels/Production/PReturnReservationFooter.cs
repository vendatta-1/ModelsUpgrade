
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PReturnReservationFooter : FooterEntity
    {
        public Guid? PreturnReservationHeaderId { get; set; }

        public Guid? PitemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        //public bool? IsPosted { get; set; }

        public virtual PItemsHeader PitemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new HashSet<PItemsStock>();

        public virtual PReturnReservationHeader PReturnReservationHeader { get; set; }

        public virtual UnitType UnitType { get; set; }

    }
}
