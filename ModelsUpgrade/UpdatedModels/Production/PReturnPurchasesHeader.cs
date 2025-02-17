
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PReturnPurchasesHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReturnNo { get; set; }

        public Guid? PinvoicePurchasesHeaderId { get; set; }



        public Guid? SuppliersDataId { get; set; }

        public Guid? DocumentsModesId { get; set; }

        public Guid? PaymentModesId { get; set; }
        [MaxLength(50)]
        public string BarcodeInvoice { get; set; }
        public DateInfo DateInfo { get; set; }


        public ObjectPricingDetails PricingDetails { get; set; }



        public virtual DocumentsMode DocumentsModes { get; set; }

        public virtual PaymentMode PaymentModes { get; set; }

        public virtual PPurchasesInvoiceHeader PinvoicePurchasesHeader { get; set; }

        public virtual ICollection<PReturnPurchasesFooter> PReturnPurchasesFooters { get; set; } = new HashSet<PReturnPurchasesFooter>();

        public virtual SupplierData SuppliersData { get; set; }

    }
}
