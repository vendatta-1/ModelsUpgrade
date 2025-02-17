using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class BranchList
{
    public Guid? BranchesDataId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string AspNetUserId { get; set; }

    public int Expr1 { get; set; }

    public string BranchName { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string BranchAddress { get; set; }

    public string BranchMobil { get; set; }

    public string BranchPhone { get; set; }

    public string BranchWhatsapp { get; set; }

    public string BranchEmail { get; set; }

    public Guid? BranchManager { get; set; }

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
