using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class GeneralAccountHeader
{
    public Guid GeneralAccountHeaderId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public int? Year { get; set; }

    public int? Mothn { get; set; }

    public DateOnly? Date { get; set; }

    public long? GeneralAccountTypeId { get; set; }

    public string Description { get; set; }

    public long? CurrencyDataId { get; set; }

    public double? TotalDebit { get; set; }

    public double? TotalCrdit { get; set; }

    public double? TotalBalance { get; set; }

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

    public virtual ICollection<GeneralAccountFooter> GeneralAccountFooters { get; set; } = new List<GeneralAccountFooter>();
}
