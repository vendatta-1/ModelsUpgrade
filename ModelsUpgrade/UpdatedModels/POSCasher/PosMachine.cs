using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.POSCasher;
public class PosMachine : Entity
{


    public Guid CompanyDataId { get; set; }

    public Guid BranchesDataId { get; set; }
    [MaxLength(50)]
    public string MachineName { get; set; }
    [MaxLength(50)]
    public string MachineSerial { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? IsPosted { get; set; } = true;

    public virtual BranchesData BranchesData { get; set; }
}
