using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.WhatsApp;

public class WhatsAppResult : Entity
{

    [MaxLength(50)]
    public string ResultNo { get; set; }

    public Guid? MessageDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public DateTime? SendDateTime { get; set; }
    public virtual WhatsAppMessageData MessageData { get; set; }

    public virtual CustomerData CustomerData { get; set; }

}
