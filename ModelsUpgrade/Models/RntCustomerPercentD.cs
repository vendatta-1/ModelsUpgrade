using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntCustomerPercentD
{
    public Guid PercentId { get; set; }

    public Guid? CustomerPercentId { get; set; }

    public double? RevenuPercent { get; set; }

    public double? RevenuValue { get; set; }

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

    public virtual RntCustomerPercentH CustomerPercent { get; set; }
}
