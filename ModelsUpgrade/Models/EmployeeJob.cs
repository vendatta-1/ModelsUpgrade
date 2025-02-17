using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EmployeeJob
{
    public Guid EmployeeJobId { get; set; }

    public Guid? EmployeeDataId { get; set; }

    public string JobName { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string CompanyName { get; set; }

    public string Time { get; set; }

    public double? PayrollValue { get; set; }

    public string Description { get; set; }

    public virtual EmployeeDatum EmployeeData { get; set; }
}
