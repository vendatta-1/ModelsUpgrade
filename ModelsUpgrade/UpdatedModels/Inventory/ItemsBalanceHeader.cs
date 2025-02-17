using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Inventory
{
    public class ItemsBalanceHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ItemsBalanceHeaderId { get; set; }//?

        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public DateInfo DateInfo { get; set; }

        public Guid? BalanceNameId { get; set; }

        public Guid? StoreDataId { get; set; }

        public double? TotalValue { get; set; } = 0.0;

        public virtual BalanceName BalanceName { get; set; }

        public virtual BranchesData BranchesData { get; set; }

        public virtual ICollection<ItemsBalanceFooter> ItemsBalanceFooters { get; set; } = new HashSet<ItemsBalanceFooter>();

        public virtual StoreData StoreData { get; set; }
    }
}
