
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.Purchasing;

namespace ModelsUpgrade.UpdatedModels.Inventory
{
    public class InventoryOrderHeader : HeaderEntity
    {
        public InventoryOrderHeader(Guid id) : base(id) { }
        protected InventoryOrderHeader()
        {

        }
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? StoreDataId { get; set; }
        public DateInfo DateInfo { get; set; }
        public string Description { get; set; }

        public double? TotalValue { get; set; } = 0.0;
        public virtual BranchesData BranchesData { get; set; }

        public virtual ICollection<InventoryOrderFooter> InventoryOrderFooters { get; set; } = new List<InventoryOrderFooter>();

        public virtual ICollection<RequestReceiptHeader> RequestReceiptHeaders { get; set; } = new List<RequestReceiptHeader>();

        public virtual StoreData StoreData { get; set; }

    }
}
