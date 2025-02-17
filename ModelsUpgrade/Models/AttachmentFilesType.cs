using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AttachmentFilesType
{
    public long AttachmentId { get; set; }

    public string AttachmentNameL1 { get; set; }

    public string AttachmentNameL2 { get; set; }

    public string Description { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<AttachmentFile> AttachmentFiles { get; set; } = new List<AttachmentFile>();
}
