using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.Medical;

public class MedCustomerDetail : Entity
{

    public Guid? CustomerDataId { get; set; }

    public Guid? AnalysisNameId { get; set; }

    public Guid? RaysNameId { get; set; }

    public string Description { get; set; }


    public virtual MedAnalysisName AnalysisName { get; set; }

    public virtual CustomerData CustomerData { get; set; }

    public virtual MedRaysName RaysName { get; set; }
}
