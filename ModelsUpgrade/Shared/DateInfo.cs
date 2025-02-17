using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.Shared
{
    [Owned]
    public record DateInfo
    (
        short? Year,
        short? Month,
        DateOnly? Date
    );
}
