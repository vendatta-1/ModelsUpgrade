using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.ManageItems;


namespace ModelsUpgrade.UpdatedModels.POSCasher;
public partial class PosSalesDetail : Entity
{
    //public Guid InvoiceDetailsId { get; set; }

    public Guid? PosSalesId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public Guid? UnitTypeId { get; set; }
    public ObjectPricingDetails PricingDetails { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual PosSale Possales { get; set; }

    public virtual ICollection<PosSalesDiscount> PossalesDiscounts { get; set; } = new HashSet<PosSalesDiscount>();
}
