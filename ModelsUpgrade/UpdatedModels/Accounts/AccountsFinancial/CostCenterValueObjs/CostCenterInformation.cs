using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.CostAccounting.SettingAccounts.CostCenterValueObjs
{
    [Owned]
    public record CostCenterInformation(
        int? Levelcode,
        long CostNumber,
        [MaxLength(200)]
        string CenterName,

        string? Description
   );
}
