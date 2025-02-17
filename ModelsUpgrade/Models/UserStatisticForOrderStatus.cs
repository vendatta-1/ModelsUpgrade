using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class UserStatisticForOrderStatus
{
    public Guid StatisticId { get; set; }

    public int? NumberOfNewOrders { get; set; }

    public int? NumberOfWaitingOrders { get; set; }

    public int? NumberOfAcceptOrders { get; set; }

    public int? NumberOfRejectOrders { get; set; }

    public int? NumberOfOrdersAcceptForOwner { get; set; }

    public int? NumberOfOrdersRejectForAdmin { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
