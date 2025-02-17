using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsBalanceFooter
{
    public Guid ItemsBalanceId { get; set; }

    public Guid? ItemsBalanceHeaderId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public string InternationalBarCode { get; set; }

    public string SupplierBarCode { get; set; }

    public string InternalCode { get; set; }

    public long? UnitTypeId { get; set; }

    public double? ItemQuantity { get; set; }

    public double? ItemQuantityDamaged { get; set; }

    public double? ItemQuantityBroken { get; set; }

    public double? ItemPrice { get; set; }

    public double? ItemValue { get; set; }

    public string Description { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ItemsBalanceHeader ItemsBalanceHeader { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual UnitType UnitType { get; set; }
}
