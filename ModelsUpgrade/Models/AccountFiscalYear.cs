using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AccountFiscalYear
{
    public long FiscalYearId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string FiscalYearNameL1 { get; set; }

    public string FiscalYearNameL2 { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateOnly? CloseDate { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual CompanyData CompanyData { get; set; }
}
