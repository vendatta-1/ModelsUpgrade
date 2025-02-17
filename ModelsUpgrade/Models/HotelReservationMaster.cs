using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class HotelReservationMaster
{
    public Guid ReservationId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public Guid? RoomId { get; set; }

    public DateOnly? ReservationDateStart { get; set; }

    public DateOnly? ReservationDateEnd { get; set; }

    public TimeOnly? EntryTime { get; set; }

    public TimeOnly? OutTime { get; set; }

    public int? NumberDays { get; set; }

    public double? ReservationValue { get; set; }

    public string Description { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual CustomerDatum CustomerData { get; set; }

    public virtual ICollection<HotelPayment> HotelPayments { get; set; } = new List<HotelPayment>();

    public virtual ICollection<HotelReservationDetail> HotelReservationDetails { get; set; } = new List<HotelReservationDetail>();

    public virtual HotelRoomDatum Room { get; set; }
}
