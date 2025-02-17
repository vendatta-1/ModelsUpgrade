using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CountryCode
{
    public long CountryId { get; set; }

    public string CodeTaxTabel { get; set; }

    public string CountryNameL1 { get; set; }

    public string CountryNameL2 { get; set; }

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

    public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; } = new List<ApplicationSetting>();

    public virtual ICollection<GovernorateCode> GovernorateCodes { get; set; } = new List<GovernorateCode>();
}
