using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewBankAtmorder : View
{
    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string GovernorateNameL1 { get; set; }

    public string CityNameL1 { get; set; }

    public string Atmmodel { get; set; }

    public string Atmserial { get; set; }

    public string Atmcode { get; set; }

    public int OrderNumberFooter { get; set; }

    public string StatusNameL1 { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public int? OrderStatusId { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? BankCodeId { get; set; }
}
