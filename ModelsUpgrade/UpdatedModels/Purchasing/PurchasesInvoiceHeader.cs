
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class PurchasesInvoiceHeader : HeaderEntity
    {

        public PurchasesInvoiceHeader(Guid id) : base(id) { }
        protected PurchasesInvoiceHeader()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceNo { get; set; }



        public Guid? RequestReceiptHeaderid { get; set; }
        [MaxLength(50)]
        public string BarcodeInvoice { get; set; }
        public DateInfo DateInfo { get; set; }

        public Guid? SuppliersDataid { get; set; }

        public Guid? DocumentsModesId { get; set; }

        public Guid? PaymentModesId { get; set; }

        //public double? TotalValue { get; set; }

        //public double? TotalDiscounts { get; set; }

        //public double? TotalAfterDiscounts { get; set; }

        //public double? TotalTaxs { get; set; }

        //public double? NetValue { get; set; }

        public ObjectPricingDetails PricingDetails { get; set; }



        public virtual DocumentsMode DocumentsModes { get; set; }

        public virtual PaymentMode PaymentModes { get; set; }

        public virtual ICollection<PurchasesInvoiceFooter> PurchasesInvoiceFooters { get; set; } = new List<PurchasesInvoiceFooter>();

        public virtual RequestReceiptHeader RequestReceiptHeader { get; set; }

        public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new HashSet<ReturnPurchasesHeader>();

        public virtual SupplierData SuppliersData { get; set; }

    }
}
