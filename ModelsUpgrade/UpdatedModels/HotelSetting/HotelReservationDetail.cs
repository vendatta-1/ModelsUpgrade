using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.HotelSetting.HotelValueObjs;

namespace ModelsUpgrade.UpdatedModels.HotelSetting;

public class HotelReservationDetail : Entity
{

    public Guid? ServicesId { get; set; }

    public Guid? ReservationMasterId { get; set; }


    public HotelPricingDetails PricingDetails { get; set; }

    public virtual HotelReservationMaster ReservationMaster { get; set; }

    public virtual HotelService Services { get; set; }
}
