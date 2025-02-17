using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntExpenseType : NamedEntity
{

    public Guid CompanyDataId { get; set; }

    public Guid BranchesDataId { get; set; }


    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<RntExpense> RntExpenses { get; set; } = new HashSet<RntExpense>();
}
