using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Purchasing;

namespace ModelsUpgrade.UpdatedModels.ManageItems;

public class ItemsPricePurchase : Entity
{


    public Guid? ItemsHeaderId { get; set; }

    public Guid? SupplierDataId { get; set; }

    public DateTime? DatePurchases { get; set; }

    public double? ItemsPrice { get; set; } = 0.0;
    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual SupplierData SupplierData { get; set; }
}
