using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class BankContract
{
    public Guid ContractId { get; set; }

    public long? BankCodeId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? Atmnumber { get; set; }

    public double? ContractValue { get; set; }

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

    public virtual BankCode BankCode { get; set; }
}
