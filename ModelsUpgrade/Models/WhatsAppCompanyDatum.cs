using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class WhatsAppCompanyData
{
    public long WhatsId { get; set; }

    public string InstanceId { get; set; }

    public string Token { get; set; }

    public string MobilNo { get; set; }

    public DateOnly? CreateDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public bool? Status { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
