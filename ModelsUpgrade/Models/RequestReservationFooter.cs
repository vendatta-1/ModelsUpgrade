using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RequestReservationFooter
{
    public Guid RequestReservationFooterId { get; set; }

    public Guid? RequestReservationHeaderId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? Price { get; set; }

    public double? Quantity { get; set; }

    public double? Value { get; set; }

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

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual RequestReservationHeader RequestReservationHeader { get; set; }

    public virtual UnitType UnitType { get; set; }
}
