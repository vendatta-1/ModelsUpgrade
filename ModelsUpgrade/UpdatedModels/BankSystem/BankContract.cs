using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.BankSystem;

public class BankContract : Entity
{


    public Guid? BankCodeId { get; set; }

    public Duration BankContractDuration { get; set; }

    public int? AtmNumber { get; set; }

    public double? ContractValue { get; set; }
    [MaxLength(200)]
    public string Description { get; set; }
    [MaxLength(250)]
    public string ImageUrl { get; set; }
    public virtual BankCode BankCode { get; set; }
}
