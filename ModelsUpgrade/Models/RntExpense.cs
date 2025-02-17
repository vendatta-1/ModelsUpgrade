using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntExpense
{
    public Guid ExpenseId { get; set; }

    public int ExpenseCodeId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public int? ExpenseTypeId { get; set; }

    public DateTime? ExpenseDate { get; set; }

    public string ExpenseDescription { get; set; }

    public double? ExpenseValue { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual RntExpenseType ExpenseType { get; set; }
}
