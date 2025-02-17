using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.ManageItems;

public class ItemsPriceSale : Entity
{

    public Guid? ItemsHeaderId { get; set; }

    public Guid? PriceTypeId { get; set; }

    public Guid? UnitTypeId { get; set; }

    public DateTime? DateSales { get; set; }

    public double? PriceValue { get; set; } = 0.0;


    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual PriceType PriceType { get; set; }

    public virtual UnitType UnitType { get; set; }
}
