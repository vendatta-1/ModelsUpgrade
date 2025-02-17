﻿using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class JournalEntriesType
{
    public long EntriesId { get; set; }

    public string EntriesNameL1 { get; set; }

    public string EntriesNameL2 { get; set; }

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
