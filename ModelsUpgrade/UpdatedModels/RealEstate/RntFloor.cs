using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntFloor : NamedEntity
{


    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FloorsCode { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? ParentCode { get; set; }

    public int? LevelCode { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<RntFloor> InverseParentCodeNavigation { get; set; } = new HashSet<RntFloor>();

    public virtual RntFloor ParentCodeNavigation { get; set; }

    public virtual ICollection<RntContractsData> RntContractsDs { get; set; } = new HashSet<RntContractsData>();
}
