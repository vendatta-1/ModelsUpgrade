namespace Link_Entities.Models;

public partial class SettlementDiscount
{
    public Guid SettlementId { get; set; }

    public int SettlementNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StoreDataId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

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

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual StoreData StoreData { get; set; }

    public virtual UnitType UnitType { get; set; }
}
