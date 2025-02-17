using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class MoneyPayment
{
    public Guid MoneyPaymentId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string PaperNumber { get; set; }

    public Guid? FromAccountNameId { get; set; }

    public Guid? ToAccountNameId { get; set; }

    public Guid? FromCashId { get; set; }

    public double? Value { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public Guid? CostCenterId { get; set; }

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

    public virtual CompanyData CompanyData { get; set; }

    public virtual CostCenter CostCenter { get; set; }

    public virtual AccountName FromAccountName { get; set; }

    public virtual AccountName FromCash { get; set; }

    public virtual AccountName ToAccountName { get; set; }
}
