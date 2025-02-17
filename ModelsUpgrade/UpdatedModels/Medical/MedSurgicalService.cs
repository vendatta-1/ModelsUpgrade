using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Medical;

public class MedSurgicalService : NamedEntity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? SurgicalServicesValue { get; set; } = 0;



    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<MedCustomerSurgicalService> MedCustomerSurgicalServices { get; set; } = new HashSet<MedCustomerSurgicalService>();
}
