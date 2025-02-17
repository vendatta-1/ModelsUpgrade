using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.Medical;
public class MedCustomerMedicalService : Entity
{


    public Guid? CustomerDataId { get; set; }

    public Guid? MedicalServicesId { get; set; }

    public string Description { get; set; }


    public virtual CustomerData CustomerData { get; set; }

    public virtual MedMedicalService MedicalServices { get; set; }
}
