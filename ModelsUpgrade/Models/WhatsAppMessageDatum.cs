using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class WhatsAppMessageData
{
    public Guid MessageId { get; set; }

    public int MessageNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string MessageDetails { get; set; }

    public DateOnly? MessageDate { get; set; }

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
}
