using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs
{
    [Owned]
    public record EmpLeveDateInfo
    {
        public short? Year { get; set; } = 0;

        public short? Month { get; set; } = 0;
        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }


    }
}
