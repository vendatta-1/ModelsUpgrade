using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntExpense : Entity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ExpenseCodeId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? ExpenseTypeId { get; set; }

    public DateTime? ExpenseDate { get; set; }

    [MaxLength(200)]
    public string Description { get; set; }

    public double? ExpenseValue { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual RntExpenseType ExpenseType { get; set; }
}
