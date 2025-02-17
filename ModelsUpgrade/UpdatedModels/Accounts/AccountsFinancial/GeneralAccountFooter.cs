using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
public class GeneralAccountFooter : TransactionFooterEntity
{
    public GeneralAccountFooter(Guid id) : base(id)
    {

    }
    protected GeneralAccountFooter()
    {

    }
    public Guid? GeneralAccountHeaderId { get; set; }

    public Guid? AccountNameId { get; set; }

    public Guid? CostCenterId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? Balance { get; set; }

    //public bool? IsPosted { get; set; }

    public virtual AccountName AccountName { get; set; }

    public virtual CostCenter CostCenter { get; set; }

    public virtual GeneralAccountHeader GeneralAccountHeader { get; set; }
}
