namespace Link_Entities.Models;

public partial class LockersDatum
{
    public Guid LockersId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string LockersNameL1 { get; set; }

    public string LockersNameL2 { get; set; }

    public Guid? AccountNameId { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual AccountName AccountName { get; set; }

    public virtual BranchesData BranchesData { get; set; }
}
