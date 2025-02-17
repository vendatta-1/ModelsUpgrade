namespace Link_Entities.Models;

public partial class EmpGroupWork
{
    public Guid GroupId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string GroupNameL1 { get; set; }

    public string GroupNameL2 { get; set; }

    public TimeOnly? OnTime { get; set; }

    public TimeOnly? OutTime { get; set; }

    public TimeOnly? OnTimes { get; set; }

    public TimeOnly? OutTimes { get; set; }

    public TimeOnly? TotalDelayTime { get; set; }

    public TimeOnly? TotalEarlyTime { get; set; }

    public int? Accept { get; set; }

    public int? EmployeeLevel { get; set; }

    public bool? OverTime { get; set; }

    public TimeOnly? TotalTime { get; set; }

    public bool? TotalTimeNotActive { get; set; }

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

    public virtual ICollection<EmployeeDatum> EmployeeData { get; set; } = new List<EmployeeDatum>();
}
