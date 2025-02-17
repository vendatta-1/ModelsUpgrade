using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PurchasesOrderHeader
{
    public Guid OrderId { get; set; }

    public int OrderNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? SupplierDataId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public double? TotalValue { get; set; }

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

    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<PurchasesOrderFooter> PurchasesOrderFooters { get; set; } = new List<PurchasesOrderFooter>();

    public virtual SupplierData SupplierData { get; set; }
}
