using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;

namespace ModelsUpgrade.UpdatedModels.POSCasher;
public class PosSession : Entity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? EmployeesDataId { get; set; }

    public DateTime? DateHeureOpen { get; set; }

    public DateTime? DateHeureClose { get; set; }

    public double? TotalValue { get; set; } = 0.0;

    public bool? IsPosted { get; set; } = true;


    public virtual BranchesData BranchesData { get; set; }

    public virtual EmployeeData EmployeesData { get; set; }
}
