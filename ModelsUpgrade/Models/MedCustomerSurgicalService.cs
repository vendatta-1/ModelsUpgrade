using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class MedCustomerSurgicalService
{
    public Guid CustomerSurgicalServicesId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public long? SurgicalServicesId { get; set; }

    public string Description { get; set; }

    public double? ServicePrice { get; set; }

    public double? Quantity { get; set; }

    public decimal? TotalValue { get; set; }

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

    public virtual MedSurgicalService SurgicalServices { get; set; }
}
