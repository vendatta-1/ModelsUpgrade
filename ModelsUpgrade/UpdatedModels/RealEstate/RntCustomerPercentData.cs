using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntCustomerPercentData : Entity
{

    public Guid? CustomerPercentId { get; set; }

    public double? RevenuPercent { get; set; }

    public double? RevenuValue { get; set; }

    public string Description { get; set; }

    public virtual RntCustomerPercentHeader CustomerPercent { get; set; }
}
