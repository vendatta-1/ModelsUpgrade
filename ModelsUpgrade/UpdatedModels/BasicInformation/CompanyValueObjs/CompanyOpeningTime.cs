using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.BasicInformation.CompanyValueObjs
{
    [Owned]
    public record CompanyOpeningTime
    (
        TimeOnly? MorningTime1,
        TimeOnly? MorningTime2,
        TimeOnly? EveningPeriod1,
        TimeOnly? EveningPeriod2
    );
}
