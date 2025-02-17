using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class PItemsBalanceFooter
{
    public Guid ItemsBalanceId { get; set; }

    public Guid? PitemsBalanceHeaderId { get; set; }

    public Guid? PitemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? ItemQuantity { get; set; }

    public double? ItemPrice { get; set; }

    public double? ItemValue { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual PItemsBalanceHeader PitemsBalanceHeader { get; set; }

    public virtual PItemsHeader PitemsHeader { get; set; }

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new List<PItemsStock>();

    public virtual UnitType UnitType { get; set; }
}
