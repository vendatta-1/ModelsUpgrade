using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewSelectReportWorkPlan : View
{
    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public Guid? BankCodeId { get; set; }

    public string BanknameL1 { get; set; }

    public string Atmmodel { get; set; }

    public string Atmserial { get; set; }

    public string Atmcode { get; set; }

    public Guid? DelegateDataId { get; set; }

    public string DelegateNameL1 { get; set; }

    public int? OrderStatusId { get; set; }

    public string StatusNameL1 { get; set; }

    public int OrderNumberFooter { get; set; }

    public string CreateUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }
}
