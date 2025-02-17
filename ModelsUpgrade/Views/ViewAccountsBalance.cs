using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewAccountsBalance : View
{
    public DateOnly? StartDate { get; set; }

    public string BalanceNameL1 { get; set; }

    public string AccountFicationNameL1 { get; set; }

    public string AccountNumber { get; set; }

    public string AccountNameL1 { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? TotalDebit { get; set; }

    public double? TotalCredit { get; set; }

    public decimal? TotalBalance { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid FicationId { get; set; }

    public Guid? BalanceNameId { get; set; }
}
