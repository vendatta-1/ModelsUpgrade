
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PRequestReceiptHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RequestReceiptNo { get; set; }


        public Guid? PpurchaseOrderHeaderId { get; set; }

        public Guid? StoreDataId { get; set; }
        public DateInfo DateInfo { get; set; }


        public double? TotalValue { get; set; } = 0.0;


        public virtual PInventoryOrderHeader PPurchaseOrderHeader { get; set; }

        public virtual ICollection<PPurchasesInvoiceHeader> PpurchasesInvoiceHeaders { get; set; } = new HashSet<PPurchasesInvoiceHeader>();

        public virtual ICollection<PRequestReceiptFooter> PrequestReceiptFooters { get; set; } = new List<PRequestReceiptFooter>();

        public virtual StoreData StoreData { get; set; }


    }
}
