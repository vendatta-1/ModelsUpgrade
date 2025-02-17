using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class LockersBalance
{
    public string BranchName { get; set; }

    public string LockersNameL1 { get; set; }

    public string AccountNumber { get; set; }

    public string AccountNameL1 { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }
}
