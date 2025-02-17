
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.HotelSetting;

public class HotelReservationMaster : Entity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public Guid? RoomId { get; set; }

    public Duration? ReservationDuration { get; set; }
    public TimeOnly? EntryTime { get; set; }

    public TimeOnly? OutTime { get; set; }

    public int? NumberDays { get; set; } = 0;

    public double? ReservationValue { get; set; } = 0.0;

    public string Description { get; set; } = string.Empty;

    public virtual CompanyData CompanyData { get; set; }
    public virtual BranchesData BranchesData { get; set; }
    public virtual CustomerData CustomerData { get; set; }

    public virtual ICollection<HotelPayment> HotelPayments { get; set; } = new List<HotelPayment>();

    public virtual ICollection<HotelReservationDetail> HotelReservationDetails { get; set; } = new List<HotelReservationDetail>();

    public virtual HotelRoomData Room { get; set; }
}
