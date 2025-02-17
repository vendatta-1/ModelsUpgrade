using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class DelegateDatum
{
    public Guid DelegateId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? DelegateBarCode { get; set; }

    public string DelegateNameL1 { get; set; }

    public string DelegateNameL2 { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string DelegateAddress { get; set; }

    public string DelegateNationalId { get; set; }

    public string DelegateMobil { get; set; }

    public string DelegatePhone { get; set; }

    public string DelegateWhatsapp { get; set; }

    public string DelegateEmail { get; set; }

    public Guid? AccountsNameId { get; set; }

    public double? SalesValue { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public string AspNetUsersId { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountName AccountsName { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<CustomerDatum> CustomerData { get; set; } = new List<CustomerDatum>();
}
