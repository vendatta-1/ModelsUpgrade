using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewItemsGroup : View
{
    public Guid ItemGroupId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public string ItemGroupNameL1 { get; set; }

    public string ItemGroupNameL2 { get; set; }

    public string ItemCodeTax { get; set; }

    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
