using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntContractsData : Entity
{

    public Guid? ContractsHid { get; set; }

    public Guid? FloorsId { get; set; }

    public Guid? UnitTypeId { get; set; }

    public string Description { get; set; }


    public virtual RntContractsHeader ContractsHeader { get; set; }

    public virtual RntFloor Floors { get; set; }

    public virtual UnitType UnitType { get; set; }
}
