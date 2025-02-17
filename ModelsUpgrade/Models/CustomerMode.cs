using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CustomerMode
{
    public long DocumentsId { get; set; }

    public string DocumentType { get; set; }

    public string DocumentNameL1 { get; set; }

    public string DocumentNameL2 { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<CustomerDatum> CustomerData { get; set; } = new List<CustomerDatum>();
}
