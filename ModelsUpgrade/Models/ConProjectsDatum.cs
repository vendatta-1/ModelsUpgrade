using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ConProjectsData
{
    public Guid ProjectId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string ProjectNameL1 { get; set; }

    public string ProjectNameL2 { get; set; }

    public string ProjectPeriod { get; set; }

    public DateOnly? ProjectStartDate { get; set; }

    public DateOnly? ProjectEndDate { get; set; }

    public double? ProjectValue { get; set; }

    public Guid? AccountsNameId { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountName AccountsName { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ConContractorExtractMaster> ConContractorExtractMasters { get; set; } = new List<ConContractorExtractMaster>();
}
