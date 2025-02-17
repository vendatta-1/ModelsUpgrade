using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs
{
    [Owned]
    public record EmployeeTimeInfo
    {
        public DateOnly? DateStart { get; set; }

        public DateOnly? DateFinsh { get; set; }

        public TimeOnly? TimeStartWork { get; set; }

        public TimeOnly? TimeEndWork { get; set; }

        public DateTime? DateBarith { get; set; }
    }
}
