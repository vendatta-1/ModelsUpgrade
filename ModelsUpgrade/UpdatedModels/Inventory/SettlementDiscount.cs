
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Inventory
{
    public class SettlementDiscount : Entity
    {
        public SettlementDiscount(Guid id) : base(id)
        {

        }

        protected SettlementDiscount()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettlementNo { get; set; }

        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? StoreDataId { get; set; }

        public Guid? ItemsHeaderId { get; set; }
        public Guid? UnitTypeId { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }

        public virtual BranchesData BranchesData { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

        public virtual StoreData StoreData { get; set; }

        public virtual UnitType UnitType { get; set; }

    }
}
