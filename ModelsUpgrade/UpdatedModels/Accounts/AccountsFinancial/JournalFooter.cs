using ModelsUpgrade.Apstractions;
namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
public class JournalFooter : TransactionFooterEntity
{
    public JournalFooter(Guid id) : base(id) { }
    protected JournalFooter()
    {

    }


    public Guid? JournalHeaderId { get; set; }

    public Guid? AccountNameId { get; set; }

    public Guid? CostCenterId { get; set; }


    public double? Balance { get; set; }

    //public bool? IsPosted { get; set; }


    public virtual AccountName AccountName { get; set; }

    public virtual CostCenter CostCenter { get; set; }

    public virtual JournalHeader JournalHeader { get; set; }
}
