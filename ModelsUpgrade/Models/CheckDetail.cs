using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CheckDetail
{
    public Guid CheckId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? CheckDate { get; set; }

    public long? BankNameId { get; set; }

    public Guid? CostCenterId { get; set; }

    public long? CheckTypeId { get; set; }

    public Guid? AccountNameFrom { get; set; }

    public Guid? AccountNameTo { get; set; }

    public long? CheckStatusId { get; set; }

    public int? CheckNumber { get; set; }

    public double? CheckValue { get; set; }

    public long? CurrencyDataId { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public DateOnly? CheckSignDate { get; set; }

    public string CheckName { get; set; }

    public int? NotifyDays { get; set; }

    public string CheckSiteName { get; set; }

    public string UnderlineCheck { get; set; }

    public string RepetitionTimes { get; set; }

    public string CheckImage { get; set; }

    public string Description { get; set; }

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

    public virtual AccountName AccountNameFromNavigation { get; set; }

    public virtual AccountName AccountNameToNavigation { get; set; }

    public virtual BankCode BankName { get; set; }

    public virtual CheckStatus CheckStatus { get; set; }

    public virtual CheckType CheckType { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual CostCenter CostCenter { get; set; }

    public virtual CurrencyDatum CurrencyData { get; set; }
}
