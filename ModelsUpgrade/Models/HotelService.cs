using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class HotelService
{
    public long ServicesId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string ServicesNameL1 { get; set; }

    public string ServicesNameL2 { get; set; }

    public double? ServicesValue { get; set; }

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

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<HotelReservationDetail> HotelReservationDetails { get; set; } = new List<HotelReservationDetail>();
}
