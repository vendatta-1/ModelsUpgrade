using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PospaymentDaily
{
    public Guid PaymentDailyId { get; set; }

    public long PaymentNo { get; set; }

    public Guid CompanyDataId { get; set; }

    public Guid BranchesDataId { get; set; }

    public Guid PossalesId { get; set; }

    public DateOnly? Date { get; set; }

    public long PaymentModesId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? Balance { get; set; }

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

    public virtual PaymentMode PaymentModes { get; set; }

    public virtual PosSale Possales { get; set; }
}
