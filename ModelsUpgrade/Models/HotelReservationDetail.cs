using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class HotelReservationDetail
{
    public Guid ReservationDetailsId { get; set; }

    public Guid? ReservationMasterId { get; set; }

    public double? ReservationValue { get; set; }

    public long? ServicesId { get; set; }

    public double? ServicesValue { get; set; }

    public double? Quantity { get; set; }

    public double? Value { get; set; }

    public double? Discount { get; set; }

    public double? Tax { get; set; }

    public double? TotalValue { get; set; }

    public virtual HotelReservationMaster ReservationMaster { get; set; }

    public virtual HotelService Services { get; set; }
}
