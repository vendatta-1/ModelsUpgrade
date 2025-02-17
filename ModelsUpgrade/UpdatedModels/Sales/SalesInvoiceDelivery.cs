
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class SalesInvoiceDelivery : Entity
    {
        public SalesInvoiceDelivery(Guid id) : base(id)
        {

        }
        protected SalesInvoiceDelivery()
        {

        }
        public Guid? InvoiceSalesHeaderId { get; set; }

        public Guid? DeliveryModesId { get; set; }
        [MaxLength(50)]
        public string Approach { get; set; }

        public string Packaging { get; set; }
        [MaxLength(50)]
        public string DateValidity { get; set; }
        [MaxLength(50)]
        public string ExportPort { get; set; }
        [MaxLength(50)]
        public string CountryOfOriginId { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal? NetWeight { get; set; }
        [MaxLength(50)]
        public string Terms { get; set; }

        public double? DeliveryValue { get; set; }

        public virtual DeliveryModes DeliveryModes { get; set; }

        public virtual SalesInvoiceHeader InvoiceSalesHeader { get; set; }
    }
}
