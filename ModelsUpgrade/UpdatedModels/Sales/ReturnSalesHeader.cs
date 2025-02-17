
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class ReturnSalesHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReturnNo { get; set; }
        public Guid? InvoiceSalesHeaderId { get; set; }
        [MaxLength(50)]
        public string BarcodeReturn { get; set; }
        public DateInfo DateInfo { get; set; }

        public Guid? CustomerDataId { get; set; }

        public Guid? DocumentsModesId { get; set; }

        public Guid? PriceTypeId { get; set; }

        public Guid? PaymentModesId { get; set; }

        public ObjectPricingDetails? PricingDetails { get; set; }



        public virtual DocumentsMode DocumentsModes { get; set; }

        public virtual SalesInvoiceHeader InvoiceSalesHeader { get; set; }

        public virtual PaymentMode PaymentModes { get; set; }

        public virtual PriceType PriceType { get; set; }

        public virtual ICollection<ReturnSalesFooter> ReturnSalesFooters { get; set; } = new HashSet<ReturnSalesFooter>();

        public virtual ICollection<SalesTaxInvoiceHeader> SalesTaxInvoiceHs { get; set; } = new HashSet<SalesTaxInvoiceHeader>();

    }
}
