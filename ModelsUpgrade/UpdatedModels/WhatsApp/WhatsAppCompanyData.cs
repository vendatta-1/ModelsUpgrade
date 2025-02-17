using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.WhatsApp;

public class WhatsAppCompanyData : Entity
{

    public string InstanceId { get; set; }

    public string Token { get; set; }

    public string MobilNo { get; set; }

    public DateOnly? CreateDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public bool? Status { get; set; }


}
