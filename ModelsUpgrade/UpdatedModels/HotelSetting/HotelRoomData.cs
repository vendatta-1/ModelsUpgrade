using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.HotelSetting;

public class HotelRoomData : Entity
{

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string RoomNumber { get; set; }

    public Guid? ParentId { get; set; }

    public int? LevelCode { get; set; } = 0;

    public Guid? RoomType { get; set; }

    public double? RoomValue { get; set; } = 0.0;

    public string Description { get; set; } = string.Empty;

    public bool? IsPosted { get; set; } = true;

    public virtual HotelRoomData Parent { get; set; }
    public virtual CompanyData CompanyData { get; set; }
    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<HotelReservationMaster> HotelReservationMasters { get; set; } = new List<HotelReservationMaster>();
}
