using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs
{
    [Owned]
    public record HRDateInfo(


         DateOnly? StartDate,
         DateOnly? EndDate,
         int? Year = 0,
         int? Month = 0
        );

}
