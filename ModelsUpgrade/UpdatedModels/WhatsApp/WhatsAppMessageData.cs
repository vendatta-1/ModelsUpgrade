using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.WhatsApp;

public class WhatsAppMessageData : Entity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int MessageNo { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string MessageDetails { get; set; }

    public DateOnly? MessageDate { get; set; }
    public virtual CompanyData CompanyData { get; set; }
    public virtual BranchesData BranchesData { get; set; }

}
