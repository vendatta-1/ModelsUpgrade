using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Medical;

public class MedMedicalService : NamedEntity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? MedicalServicesValue { get; set; } = 0;



    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<MedCustomerMedicalService> MedCustomerMedicalServices { get; set; } = new HashSet<MedCustomerMedicalService>();
}
