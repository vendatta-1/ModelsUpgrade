using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpAcceptType
{
    public long AcceptId { get; set; }

    public string AcceptNameL1 { get; set; }

    public string AcceptNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EmpAccept> EmpAccepts { get; set; } = new List<EmpAccept>();
}
