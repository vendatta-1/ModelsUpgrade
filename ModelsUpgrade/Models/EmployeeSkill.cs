using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmployeeSkill
{
    public Guid SkillsId { get; set; }

    public Guid? EmployeeDataId { get; set; }

    public string SkillsName { get; set; }

    public string Descriptions { get; set; }

    public string Darega { get; set; }

    public virtual EmployeeDatum EmployeeData { get; set; }
}
