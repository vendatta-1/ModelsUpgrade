using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.RealEstate;
public class RntReceiptsData : Entity
{


    public Guid? ReceiptHeader { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public double? DueValue { get; set; }

    public double? PaidValue { get; set; }

    public double? RemainingValue { get; set; }

    public double? DiscountValue { get; set; }

    public double? NetValue { get; set; }
    [MaxLength(255)]
    public string ReciptNo { get; set; }

    public string Description { get; set; }

    public virtual RntReceiptsHeader ReceiptHeaderNavigation { get; set; }
}
