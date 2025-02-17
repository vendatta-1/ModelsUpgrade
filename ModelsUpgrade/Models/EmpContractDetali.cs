using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpContractDetali
{
    public Guid ContractId { get; set; }

    public Guid? EmpContractHid { get; set; }

    public long? EmpElementTypeId { get; set; }

    public long? EmpElementDataId { get; set; }

    public double? ValueElment { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual EmpContractMaster EmpContractH { get; set; }

    public virtual EmpElementDatum EmpElementData { get; set; }

    public virtual EmpElementType EmpElementType { get; set; }
}
