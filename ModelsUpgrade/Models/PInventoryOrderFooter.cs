namespace Link_Entities.Models;

public partial class PInventoryOrderFooter
{
    public Guid PpurchaseOrderFooterId { get; set; }

    public Guid? PpurchaseOrderHeaderId { get; set; }

    public Guid? PitemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public double? Value { get; set; }

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

    public virtual PItemsHeader PitemsHeader { get; set; }

    public virtual PInventoryOrderHeader PpurchaseOrderHeader { get; set; }

    public virtual UnitType UnitType { get; set; }
}
