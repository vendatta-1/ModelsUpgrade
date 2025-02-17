
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PInventoryOrderHeader : HeaderEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderNo { get; set; }


        public Guid? StoreDataId { get; set; }


        public double? TotalValue { get; set; }
        public DateInfo DateInfo { get; set; }



        public virtual ICollection<PInventoryOrderFooter> PinventoryOrderFooters { get; set; } = new HashSet<PInventoryOrderFooter>();

        public virtual ICollection<PRequestReceiptHeader> PrequestReceiptHeaders { get; set; } = new List<PRequestReceiptHeader>();

        public virtual StoreData StoreData { get; set; }
    }
}
