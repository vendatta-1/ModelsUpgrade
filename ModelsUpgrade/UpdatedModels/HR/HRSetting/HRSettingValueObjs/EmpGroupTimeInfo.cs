using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs
{
    [Owned]
    public record EmpGroupTimeInfo
    {
        public TimeOnly? OnTime { get; set; }

        public TimeOnly? OutTime { get; set; }

        public TimeOnly? OnTimes { get; set; }

        public TimeOnly? OutTimes { get; set; }

        public TimeOnly? TotalDelayTime { get; set; }

        public TimeOnly? TotalEarlyTime { get; set; }
    }
}
