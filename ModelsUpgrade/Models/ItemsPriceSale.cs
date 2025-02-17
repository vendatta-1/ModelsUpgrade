using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsPriceSale
{
    public Guid ItemsPriceId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public long? PriceTypeId { get; set; }

    public long? UnitTypeId { get; set; }

    public DateTime? DateSales { get; set; }

    public double? PriceValue { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public string Modifiedby { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual PriceType PriceType { get; set; }

    public virtual UnitType UnitType { get; set; }
}
