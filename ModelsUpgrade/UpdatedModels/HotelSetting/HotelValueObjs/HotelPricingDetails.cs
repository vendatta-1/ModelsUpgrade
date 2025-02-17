using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.HotelSetting.HotelValueObjs
{
    [Owned]
    public record HotelPricingDetails
    {
        public double? ReservationValue { get; set; }

        public double? ServicesValue { get; set; }

        public double? Quantity { get; set; }

        public double? Value { get; set; }

        public double? Discount { get; set; }

        public double? Tax { get; set; }

        public double? TotalValue { get; set; }
    }
}
