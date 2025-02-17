using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class MedCustomerMedicalService
{
    public Guid CustomerServicesId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public long? MedicalServicesId { get; set; }

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

    public virtual MedMedicalService MedicalServices { get; set; }
}
