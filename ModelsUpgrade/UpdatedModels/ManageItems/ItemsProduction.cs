using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ManageItems;

public class ItemsProduction : Entity
{



    public Guid? ItemsHeaderId { get; set; }

    public DateOnly? ProductionDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }
    public virtual ItemsHeader ItemsHeader { get; set; }
}
