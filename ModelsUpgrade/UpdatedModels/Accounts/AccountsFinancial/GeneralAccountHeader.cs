using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
public class GeneralAccountHeader : DatedInfoEntity
{
    public GeneralAccountHeader(Guid id) : base(id)
    {

    }
    protected GeneralAccountHeader()
    {

    }


    public Guid? GeneralAccountTypeId { get; set; }

    public Guid? CurrencyDataId { get; set; }

    public virtual ICollection<GeneralAccountFooter> GeneralAccountFooters { get; set; } = new HashSet<GeneralAccountFooter>();
}
