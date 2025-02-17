using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewSelectJournal : View
{
    public Guid JournalHeaderId { get; set; }

    public int JournalNo { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string CurrencyNameL1 { get; set; }

    public string Description { get; set; }

    public string CenterName { get; set; }

    public string AccountNameL1 { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? TotalDebit { get; set; }

    public double? TotalCredit { get; set; }

    public double? TotalBalance { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }
}
