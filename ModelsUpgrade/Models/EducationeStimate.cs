using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EducationeStimate
{
    public long EducationestimateId { get; set; }

    public string StimateNameL1 { get; set; }

    public string StimateNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new List<EduStudentData>();

    public virtual ICollection<EmployeeDatum> EmployeeData { get; set; } = new List<EmployeeDatum>();
}
