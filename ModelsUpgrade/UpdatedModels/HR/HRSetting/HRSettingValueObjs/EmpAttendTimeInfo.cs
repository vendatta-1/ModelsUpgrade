using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs
{
    [Owned]
    public record EmpAttendTimeInfo
    {
        public TimeOnly? OnTime { get; set; }

        public TimeOnly? OutTime { get; set; }

        public TimeOnly? OnTimes { get; set; }

        public TimeOnly? OutTimes { get; set; }

        public TimeOnly? OverTime { get; set; }

        public TimeOnly? TotalTime { get; set; }
    }
}
