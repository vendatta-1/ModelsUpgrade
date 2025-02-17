using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class GovernorateCode
{
    public long GovernorateId { get; set; }

    public long? CountryCodeId { get; set; }

    public string GovernorateNameL1 { get; set; }

    public string GovernorateNameL2 { get; set; }

    public bool? Posted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<BankAtm> BankAtms { get; set; } = new List<BankAtm>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new List<BankCode>();

    public virtual ICollection<CityCode> CityCodes { get; set; } = new List<CityCode>();

    public virtual CountryCode CountryCode { get; set; }

    public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new List<WorkPlanHeader>();
}
