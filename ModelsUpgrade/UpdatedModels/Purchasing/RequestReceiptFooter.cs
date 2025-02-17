using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class RequestReceiptFooter : Entity
    {
        public RequestReceiptFooter(Guid id) : base(id)
        {

        }
        protected RequestReceiptFooter()
        {

        }

        public Guid? RequestReceiptHeaderId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? UnitTypeId { get; set; }

        public PurchaseInfo RequestPurchaseInfo { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual RequestReceiptHeader RequestReceiptHeader { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
