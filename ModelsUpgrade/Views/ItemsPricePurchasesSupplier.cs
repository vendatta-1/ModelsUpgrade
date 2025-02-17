using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ItemsPricePurchasesSupplier : View
{
    public string InternalCode { get; set; }

    public string ItemNameL1 { get; set; }

    public string ItemNameL2 { get; set; }

    public string SupplierName { get; set; }

    public DateTime? DatePurchases { get; set; }

    public decimal? ItemsPrice { get; set; }
}
