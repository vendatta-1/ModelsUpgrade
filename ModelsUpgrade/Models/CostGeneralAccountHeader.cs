using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CostGeneralAccountHeader
{
    public Guid JournalHeaderId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public long? Year { get; set; }

    public long? Month { get; set; }

    public DateOnly? Date { get; set; }

    public long? CurrencyDataId { get; set; }

    public string Description { get; set; }

    public double? Totaldebit { get; set; }

    public double? Totalcredit { get; set; }

    public double? Totalbalance { get; set; }

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

    public virtual ICollection<CostGeneralAccountFooter> CostGeneralAccountFooters { get; set; } = new List<CostGeneralAccountFooter>();

    public virtual CurrencyDatum CurrencyData { get; set; }
}
