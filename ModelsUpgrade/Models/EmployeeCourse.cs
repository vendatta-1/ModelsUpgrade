using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmployeeCourse
{
    public Guid EmployeeDetailsId { get; set; }

    public Guid? EmployeeDataId { get; set; }

    public string CourseName { get; set; }

    public string Description { get; set; }

    public string Years { get; set; }

    public string Academy { get; set; }
}
