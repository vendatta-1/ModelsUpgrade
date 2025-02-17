using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.Contractors;

public class ConProjectItem : NamedEntity
{


    public Guid? CompanyDataId { get; set; }


    public double? ItemValue { get; set; }


    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ConContractorExtractDetail> ConContractorExtractDetails { get; set; } = new HashSet<ConContractorExtractDetail>();
}
