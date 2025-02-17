
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PPurchasesInvoiceHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long InvoiceNo { get; set; }


        public Guid? PrequestReceiptHeaderid { get; set; }
        [MaxLength(50)]
        public string BarcodeInvoice { get; set; }
        public DateInfo DateInfo { get; set; }

        public Guid? SuppliersDataid { get; set; }

        public Guid? DocumentsModesId { get; set; }
        public ObjectPricingDetails PricingDetails { get; set; }


        public virtual ICollection<PPurchasesInvoiceFooter> PpurchasesInvoiceFooters { get; set; } = new HashSet<PPurchasesInvoiceFooter>();

        public virtual PRequestReceiptHeader PrequestReceiptHeader { get; set; }

        public virtual ICollection<PReturnPurchasesHeader> PReturnPurchasesHeaders { get; set; } = new HashSet<PReturnPurchasesHeader>();

        public virtual SupplierData SuppliersData { get; set; }

    }
}
