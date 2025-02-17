using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class JournalHeader
{
    public Guid JournalHeaderId { get; set; }

    public int JournalNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public long? CurrencyDataId { get; set; }

    public string Description { get; set; }

    public double? TotalDebit { get; set; }

    public double? TotalCredit { get; set; }

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

    public virtual CompanyData CompanyData { get; set; }

    public virtual CurrencyDatum CurrencyData { get; set; }

    public virtual ICollection<JournalFooter> JournalFooters { get; set; } = new List<JournalFooter>();
}
