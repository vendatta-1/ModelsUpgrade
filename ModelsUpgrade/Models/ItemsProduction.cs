using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsProduction
{
    public Guid ItemsProductionId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public DateOnly? ProductionDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public string Modifiedby { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }
}
