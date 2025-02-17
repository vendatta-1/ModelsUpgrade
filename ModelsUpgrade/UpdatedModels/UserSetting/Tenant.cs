using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.UserSetting;

public class Tenant : NamedEntity
{
    public Tenant(string tenantCode, string imageUrl, string connectionString)
    {
        TenantCode = tenantCode;
        ImageUrl = imageUrl;
        ConnectionString = connectionString;

    }
    public string TenantCode { get; private set; }
    public string ImageUrl { get; private set; }
    public string ConnectionString { get; private set; }
    //public Guid DeletedById { get; set; }
    //[ForeignKey("DeletedById")]
    //public virtual AppUser DeletedBy { get; set; }
}
