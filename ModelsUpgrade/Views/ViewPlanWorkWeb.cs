using System;
using System.Collections.Generic;

namespace ModelsUpgrade.Views;

public partial class ViewPlanWorkWeb
{
    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? DetailsDate { get; set; }

    public string Atmcode { get; set; }

    public string Atmserial { get; set; }

    public string Atmaddress { get; set; }

    public string AspNetUsersId { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }

    public long? BankCodeId { get; set; }

    public int? OrderStatusId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public Guid FooterId { get; set; }
}
