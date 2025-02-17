namespace Link_Entities.Models;

public partial class InventoryOrderHeader
{
    public Guid InventoryOrderHeaderId { get; set; }

    public int OrderNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StoreDataId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }

    public double? TotalValue { get; set; }

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

    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<InventoryOrderFooter> InventoryOrderFooters { get; set; } = new List<InventoryOrderFooter>();

    public virtual ICollection<RequestReceiptHeader> RequestReceiptHeaders { get; set; } = new List<RequestReceiptHeader>();

    public virtual StoreData StoreData { get; set; }
}
