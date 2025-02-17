using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class CrmContact : Entity
{
    //this max length based on DbContext

    [MaxLength(255)]
    public string Email { get; set; }
    [MaxLength(255)]

    public string Company { get; set; }
    [MaxLength(255)]

    public string LastName { get; set; }
    [MaxLength(255)]
    public string FirstName { get; set; }

    public string Phone { get; set; }

    public virtual ICollection<CrmOpportunity> CrmOpportunities { get; set; } = new HashSet<CrmOpportunity>();
}
