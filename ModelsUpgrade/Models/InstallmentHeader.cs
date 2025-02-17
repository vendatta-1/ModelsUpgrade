using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class InstallmentHeader
{
    public long InstallmentHeaderId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public int? Years { get; set; }

    public int? Month { get; set; }

    public DateOnly? StartDate { get; set; }

    public double? TotalValue { get; set; }

    public double? FirstBatch { get; set; }

    public decimal? InterestRate { get; set; }

    public double? NetValue { get; set; }

    public int? NumberInstallments { get; set; }

    public double? ValueInstallment { get; set; }

    public int? InstallmentPeriod { get; set; }

    public decimal? DelayInterestRate { get; set; }

    public string Declaration { get; set; }

    public string FileUrl { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual CustomerDatum CustomerData { get; set; }

    public virtual ICollection<InstallmentFooter> InstallmentFooters { get; set; } = new List<InstallmentFooter>();
}
