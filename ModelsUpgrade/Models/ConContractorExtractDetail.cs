using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ConContractorExtractDetail
{
    public Guid ContractorDetailsId { get; set; }

    public Guid? ContractorMasterId { get; set; }

    public Guid? ProjectItemsId { get; set; }

    public double? ItemPrice { get; set; }

    public long? UnitTypeId { get; set; }

    public string Quantity { get; set; }

    public double? Value { get; set; }

    public double? ImplementationRate { get; set; }

    public double? NetValue { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ConContractorExtractMaster ContractorMaster { get; set; }

    public virtual ConProjectItem ProjectItems { get; set; }

    public virtual UnitType UnitType { get; set; }
}
