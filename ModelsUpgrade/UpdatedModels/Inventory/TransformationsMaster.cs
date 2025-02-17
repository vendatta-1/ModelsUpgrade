using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Inventory;

public class TransformationsMaster : Entity
{

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TransformationNo { get; set; }

    public DateOnly? Date { get; set; }

    public Guid? FromId { get; set; }

    public Guid? ToId { get; set; }

    public double? TotalValue { get; set; }


    public virtual CompanyData CompanyData { get; set; }

    public virtual StoreData From { get; set; }

    public virtual StoreData To { get; set; }

    public virtual ICollection<TransformationsDetail> TransformationsDetails { get; set; } = new HashSet<TransformationsDetail>();
}
