using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
public class JournalHeader : DatedInfoEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JournalNo { get; set; }

    //public Guid? CompanyDataId { get; set; }

    //public Guid? BranchesDataId { get; set; }


    public Guid? CurrencyDataId { get; set; }


    public virtual CurrencyData CurrencyData { get; set; }

    public virtual ICollection<JournalFooter> JournalFooters { get; set; } = new HashSet<JournalFooter>();
}
