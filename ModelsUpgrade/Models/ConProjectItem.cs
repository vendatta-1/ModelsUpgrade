using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ConProjectItem
{
    public Guid ItemsId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public double? ItemValue { get; set; }

    public string Description { get; set; }

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

    public virtual ICollection<ConContractorExtractDetail> ConContractorExtractDetails { get; set; } = new List<ConContractorExtractDetail>();
}
