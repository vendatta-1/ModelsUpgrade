using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Contractors.ContractorsValueObjs;

namespace ModelsUpgrade.UpdatedModels.Contractors;

public class ConContractorExtractMaster : Entity
{

    public Guid? CompanyDateId { get; set; }

    public Guid? ContractorDataId { get; set; }

    public Guid? ProjectDataId { get; set; }

    public DateOnly? Date { get; set; }

    public Duration? Duration { get; set; }

    public ContractMasterPricing MasterPricing { get; set; }

    public string NumberLetters { get; set; }


    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ConContractorExtractDetail> ConContractorExtractDetails { get; set; } = new HashSet<ConContractorExtractDetail>();

    public virtual ConContractorData ContractorData { get; set; }

    public virtual ConProjectsData ProjectData { get; set; }
}
