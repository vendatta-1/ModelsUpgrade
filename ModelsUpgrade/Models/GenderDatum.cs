using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class GenderDatum
{
    public long GenderId { get; set; }

    public string GenderNameL1 { get; set; }

    public string GenderNameL2 { get; set; }

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
