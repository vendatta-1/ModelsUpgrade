using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AccountFixedDetail
{
    public long FixedId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public long? AccountFicationId { get; set; }

    public Guid? AccountNameId { get; set; }

    public Guid? AccountNameLevel2Id { get; set; }

    public string FixedNameL1 { get; set; }

    public string FixedNameL2 { get; set; }

    public DateOnly? BuyDate { get; set; }

    public string Location { get; set; }

    public string Responsible { get; set; }

    public double? BuyValue { get; set; }

    public int? Months { get; set; }

    public Guid? CostCenterId { get; set; }

    public double? Rate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public double? CurrentValue { get; set; }

    public int? DepreciationAccId { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountFication AccountFication { get; set; }

    public virtual AccountName AccountName { get; set; }

    public virtual AccountName AccountNameLevel2 { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual CostCenter CostCenter { get; set; }
}
