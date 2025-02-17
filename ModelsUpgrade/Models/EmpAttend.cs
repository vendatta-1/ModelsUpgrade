using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmpAttend
{
    public long AttendId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? EmployeesDataId { get; set; }

    public long? AttendTypeId { get; set; }

    public long? EmpDayWeekId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? OnTime { get; set; }

    public TimeOnly? OutTime { get; set; }

    public TimeOnly? OnTimes { get; set; }

    public TimeOnly? OutTimes { get; set; }

    public TimeOnly? OverTime { get; set; }

    public TimeOnly? TotalTime { get; set; }

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

    public virtual EmpAttendType AttendType { get; set; }

    public virtual EmpDayWeek EmpDayWeek { get; set; }

    public virtual EmployeeDatum EmployeesData { get; set; }
}
