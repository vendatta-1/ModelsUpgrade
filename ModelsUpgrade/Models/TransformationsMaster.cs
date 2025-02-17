using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class TransformationsMaster
{
    public Guid TransMasterId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public int TransformationNo { get; set; }

    public DateOnly? Date { get; set; }

    public Guid? FromId { get; set; }

    public Guid? ToId { get; set; }

    public double? TotalValue { get; set; }

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

    public virtual StoreData From { get; set; }

    public virtual StoreData To { get; set; }

    public virtual ICollection<TransformationsDetail> TransformationsDetails { get; set; } = new List<TransformationsDetail>();
}
