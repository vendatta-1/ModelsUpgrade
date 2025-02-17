using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.Medical;

public partial class MedAnalysisName : NamedEntity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }




    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<MedCustomerDetail> MedCustomerDetails { get; set; } = new HashSet<MedCustomerDetail>();
}
