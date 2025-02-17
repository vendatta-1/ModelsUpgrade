
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;
using ModelsUpgrade.UpdatedModels.Sales.SalesValueObjs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class SalesInvoiceHeader : HeaderEntity
    {

        public SalesInvoiceHeader(Guid id) : base(id)
        {

        }
        protected SalesInvoiceHeader()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceNo { get; set; }



        public Guid? RequestReservationHeaderId { get; set; }
        [MaxLength(50)]
        public string BarcodeInvoice { get; set; }
        public DateInfo DateInfo { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public Guid? CustomerDataId { get; set; }

        public Guid? DocumentsModesId { get; set; }

        public Guid? PriceTypeId { get; set; }

        public Guid? PaymentModesId { get; set; }
        public SalesInvoiceHeaderPricing PricingDetails { get; set; }



        public virtual CustomerData CustomerData { get; set; }

        public virtual DocumentsMode DocumentsModes { get; set; }

        public virtual PaymentMode PaymentModes { get; set; }

        public virtual PriceType PriceType { get; set; }

        public virtual RequestReservationHeader RequestReservationHeader { get; set; }

        public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new HashSet<ReturnSalesHeader>();

        public virtual ICollection<SalesInvoiceDelivery> SalesInvoiceDeliveries { get; set; } = new HashSet<SalesInvoiceDelivery>();

        public virtual ICollection<SalesInvoiceFooter> SalesInvoiceFooters { get; set; } = new HashSet<SalesInvoiceFooter>();

        public virtual ICollection<SalesInvoicePayment> SalesInvoicePayments { get; set; } = new HashSet<SalesInvoicePayment>();

        public virtual ICollection<SalesTaxInvoiceHeader> SalesTaxInvoiceHs { get; set; } = new HashSet<SalesTaxInvoiceHeader>();
    }
}
