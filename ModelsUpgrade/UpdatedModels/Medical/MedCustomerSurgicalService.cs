using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.Medical;

public class MedCustomerSurgicalService : Entity
{


    public Guid? CustomerDataId { get; set; }

    public Guid? SurgicalServicesId { get; set; }
    public string Description { get; set; }

    public PurchaseInfo? PurchaseInfo { get; set; }


    public virtual CustomerData CustomerData { get; set; }

    public virtual MedSurgicalService SurgicalServices { get; set; }
}
