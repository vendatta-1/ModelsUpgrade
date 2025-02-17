using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntReceiptsHeader : HeaderEntity
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReceiptCode { get; set; }



    public Guid? ContractsId { get; set; }

    public Guid? CurrencyDataId { get; set; }

    public DateTime? ReceiptDate { get; set; }


    public virtual RntContractsHeader Contracts { get; set; }

    public virtual CurrencyData CurrencyData { get; set; }

    public virtual ICollection<RntReceiptsData> RntReceiptsDs { get; set; } = new HashSet<RntReceiptsData>();
}
