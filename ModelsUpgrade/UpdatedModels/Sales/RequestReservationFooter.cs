using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class RequestReservationFooter : FooterEntity
    {
        public RequestReservationFooter(Guid id) : base(id) { }
        protected RequestReservationFooter()
        {

        }
        public Guid? RequestReservationHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }
        //public double? Price { get; set; }

        //public double? Quantity { get; set; }

        //public double? Value { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        //public bool? IsPosted { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual RequestReservationHeader RequestReservationHeader { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
