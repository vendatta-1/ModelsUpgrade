using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Inventory;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using System.ComponentModel.DataAnnotations.Schema;
namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class RequestReceiptHeader : HeaderEntity
    {

        public RequestReceiptHeader(Guid id) : base(id) { }
        protected RequestReceiptHeader()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestReceiptNo { get; set; }



        public Guid? PurchaseOrderHeaderId { get; set; }

        public Guid? StoreDataId { get; set; }

        public DateInfo RequestReciptDateInfo { get; set; }

        public string Description { get; set; }
        public double TotalValue { get; set; } = 0.0;


        public virtual InventoryOrderHeader PurchaseOrderHeader { get; set; }

        public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new HashSet<PurchasesInvoiceHeader>();

        public virtual ICollection<RequestReceiptFooter> RequestReceiptFooters { get; set; } = new HashSet<RequestReceiptFooter>();

        public virtual StoreData StoreData { get; set; }
    }
}
