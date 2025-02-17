
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PRequestReservationFooter : FooterEntity
    {
        public Guid? PrequestReservationHeaderId { get; set; }

        public Guid? PItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        //public bool? IsPosted { get; set; }
        public virtual PItemsHeader PItemsHeader { get; set; }

        public virtual ICollection<PItemsStock> PItemsStocks { get; set; } = new List<PItemsStock>();

        public virtual PRequestReservationHeader PRequestReservationHeader { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
