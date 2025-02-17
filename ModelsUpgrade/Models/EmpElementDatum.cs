﻿using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpElementDatum
{
    public long ElementId { get; set; }

    public string ElementNameL1 { get; set; }

    public string ElementNameL2 { get; set; }

    public long? EmpElemntNaturId { get; set; }

    public long? EmpElemntTypeId { get; set; }

    public bool? MonthNotActive { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EmpContractDetali> EmpContractDetalis { get; set; } = new List<EmpContractDetali>();

    public virtual EmpElementNature EmpElemntNatur { get; set; }

    public virtual EmpElementType EmpElemntType { get; set; }
}
