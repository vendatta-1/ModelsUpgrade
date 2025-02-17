using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Contractors;

public class ConProjectsData : NamedEntity
{


    public Guid? CompanyDataId { get; set; }
    public Guid? AccountsNameId { get; set; }

    public string ProjectPeriod { get; set; }

    public Duration? ProjectDuration { get; set; }

    public double? ProjectValue { get; set; }


    [MaxLength(250)]
    public string ImageUrl { get; set; }

    public virtual AccountName AccountsName { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual ICollection<ConContractorExtractMaster> ConContractorExtractMasters { get; set; } = new HashSet<ConContractorExtractMaster>();
}
