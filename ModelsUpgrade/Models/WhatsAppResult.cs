using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class WhatsAppResult
{
    public Guid ResultId { get; set; }

    public string ResultNo { get; set; }

    public Guid? MessageDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public DateTime? SendDateTime { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
