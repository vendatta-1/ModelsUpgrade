using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ConContractorExtractMaster
{
    public Guid ContractorId { get; set; }

    public Guid? CompanyDateId { get; set; }

    public Guid? ContractorDataId { get; set; }

    public Guid? ProjectDataId { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public double? TotalValu { get; set; }

    public double? TotalTax { get; set; }

    public double? TotalDiscount { get; set; }

    public double? Payments { get; set; }

    public double? NetTotal { get; set; }

    public string NumberLetters { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual CompanyData CompanyDate { get; set; }

    public virtual ICollection<ConContractorExtractDetail> ConContractorExtractDetails { get; set; } = new List<ConContractorExtractDetail>();

    public virtual ConContractorDatum ContractorData { get; set; }

    public virtual ConProjectsData ProjectData { get; set; }
}
