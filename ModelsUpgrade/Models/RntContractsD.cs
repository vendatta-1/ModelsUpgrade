using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntContractsD
{
    public Guid ContractId { get; set; }

    public Guid? ContractsHid { get; set; }

    public Guid? FloorsId { get; set; }

    public long? UnitTypeId { get; set; }

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

    public virtual RntContractsH ContractsH { get; set; }

    public virtual RntFloor Floors { get; set; }

    public virtual UnitType UnitType { get; set; }
}
