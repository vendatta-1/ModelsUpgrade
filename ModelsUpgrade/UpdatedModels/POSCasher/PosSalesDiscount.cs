using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.POSCasher;
public class PosSalesDiscount : Entity
{

    public Guid? PossalesDetailsId { get; set; }

    public Guid? PosreturnSalesFooterId { get; set; }

    public Guid? DiscountTypeId { get; set; }

    public double? DiscountRate { get; set; } = 0.0;

    public double? DiscountAmount { get; set; } = 0.0;

    public virtual PosSalesDetail PosSalesDetails { get; set; }
}
