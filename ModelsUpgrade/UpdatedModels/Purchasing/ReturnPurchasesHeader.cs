
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.Purchasing.PurchasingValueObjs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class ReturnPurchasesHeader : HeaderEntity
    {
        public ReturnPurchasesHeader(Guid id) : base(id) { }
        protected ReturnPurchasesHeader()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReturnNo { get; set; }

        public Guid? PurchasesInvoiceHeaderId { get; set; }



        [MaxLength(50)]
        public string BarcodeInvoice { get; set; }

        public Guid? SuppliersDataId { get; set; }

        public Guid? DocumentsModesId { get; set; }

        public Guid? PaymentModesId { get; set; }


        public ReturnPurchaseHeaderPrice PurchasePricing { get; set; }
        public DateInfo DateInfo { get; set; }

        public virtual DocumentsMode DocumentsModes { get; set; }

        public virtual PaymentMode PaymentModes { get; set; }

        public virtual PurchasesInvoiceHeader PurchasesInvoiceHeader { get; set; }

        public virtual ICollection<ReturnPurchasesFooter> ReturnPurchasesFooters { get; set; } = new HashSet<ReturnPurchasesFooter>();

        public virtual SupplierData SuppliersData { get; set; }


    }
}
