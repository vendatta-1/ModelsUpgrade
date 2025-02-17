using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class DeliveryModes : NamedEntity
    {
        [MaxLength(5)]
        public string CodeTax { get; set; }
        public virtual ICollection<SalesInvoiceDelivery> SalesInvoiceDeliveries { get; set; } = new HashSet<SalesInvoiceDelivery>();
    }
}
