namespace Link_Entities.Models;

public partial class PAdditionAdjustment
{
    public Guid AdditionId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StoreDataId { get; set; }

    public Guid? PitemsHeaderId { get; set; }

    public long? UnitTypeId { get; set; }

    public double? UnitPrice { get; set; }

    public double? Quantity { get; set; }

    public double? TotalValue { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual PItemsHeader PitemsHeader { get; set; }

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new List<PItemsStock>();

    public virtual StoreData StoreData { get; set; }

    public virtual UnitType UnitType { get; set; }
}
