using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RecruitmentDatum
{
    public long RecruitmentId { get; set; }

    public string RecruitmentNameL1 { get; set; }

    public string RecruitmentNameL2 { get; set; }

    public bool? IsNotactive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isdeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new List<EduStudentData>();

    public virtual ICollection<EmployeeDatum> EmployeeData { get; set; } = new List<EmployeeDatum>();
}
