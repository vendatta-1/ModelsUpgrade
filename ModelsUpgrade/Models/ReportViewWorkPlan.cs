using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ReportViewWorkPlan
{
    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int OrderNumberFooter { get; set; }

    public int? OrderStatusId { get; set; }

    public string StatusNameL1 { get; set; }

    public string Atmserial { get; set; }

    public string Atmaddress { get; set; }

    public string Atmlocation { get; set; }

    public string AspNetUsersId { get; set; }

    public string ImageUrl { get; set; }

    public string BanknameL1 { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid FooterId { get; set; }

    public Guid? BankAtmid { get; set; }
}
