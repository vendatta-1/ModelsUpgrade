namespace Link_Entities.Models;

public partial class Posmachine
{
    public long MachineId { get; set; }

    public Guid CompanyDataId { get; set; }

    public Guid BranchesDataId { get; set; }

    public string MachineName { get; set; }

    public string MachineSerial { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

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
}
