using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class HotelRoomDatum
{
    public Guid RoomId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string RoomNumber { get; set; }

    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public long? RoomType { get; set; }

    public double? RoomValue { get; set; }

    public string Description { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<HotelReservationMaster> HotelReservationMasters { get; set; } = new List<HotelReservationMaster>();
}
