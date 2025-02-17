using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.UserSetting;

public class TenantUser : Entity
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TenantUserId { get; set; }

    public Tenant Tenant { get; set; }
    public string UserId { get; set; }
    public bool Disabled { get; set; }
    public bool IsTenantAdmin { get; set; }
    public string CurrentUserId { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }
}