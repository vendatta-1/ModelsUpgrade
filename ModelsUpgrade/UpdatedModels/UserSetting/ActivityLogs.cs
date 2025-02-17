using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.UserSetting;

public class ActivityLogs : Entity
{


    public Guid EmployeeId { get; set; }
    public Guid UserId { get; set; }
    public DateTime LoginDate { get; set; }

}
