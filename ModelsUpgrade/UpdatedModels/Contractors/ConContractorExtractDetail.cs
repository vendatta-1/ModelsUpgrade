using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Contractors;

public class ConContractorExtractDetail : Entity
{


    public Guid? ContractorMasterId { get; set; }

    public Guid? ProjectItemsId { get; set; }
    public Guid? UnitTypeId { get; set; }

    public PurchaseInfo PurchaseInfo { get; set; }

    public double? ImplementationRate { get; set; }

    public double? NetValue { get; set; }//

    public virtual ConContractorExtractMaster ContractorMaster { get; set; }

    public virtual ConProjectItem ProjectItems { get; set; }

    public virtual UnitType UnitType { get; set; }
}
