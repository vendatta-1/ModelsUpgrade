using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class BranchesList
{
    public Guid BranchListId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string AspNetUserId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual CompanyData CompanyData { get; set; }
}
