using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class BankAtm
{
    public Guid Atmid { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public long? BankCodeId { get; set; }

    public DateOnly? StartDate { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string Atmmodel { get; set; }

    public string Atmserial { get; set; }

    public string Atmcode { get; set; }

    public string Atmaddress { get; set; }

    public int? AtmcounterForMonth { get; set; }

    public string Atmlocation { get; set; }

    public string Atmlong { get; set; }

    public string Atmlat { get; set; }

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

    public virtual BankCode BankCode { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual GovernorateCode GovernorateCode { get; set; }

    public virtual ICollection<WorkPlanFooter> WorkPlanFooters { get; set; } = new List<WorkPlanFooter>();
}
