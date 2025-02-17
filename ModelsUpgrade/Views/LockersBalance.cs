using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class LockersBalance : View
{
    public string BranchName { get; set; }

    public string LockersNameL1 { get; set; }

    public string AccountNumber { get; set; }

    public string AccountNameL1 { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }
}
