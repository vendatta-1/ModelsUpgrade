
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class TaxableType : NamedEntity
    {
        [MaxLength(4)]
        public string TaxTable { get; set; }
        [MaxLength(50)]
        public string TaxCode { get; set; }

        public double? TaxPercent { get; set; } = 0.0;

        public Guid? ParentCodeId { get; set; }

        public int? LevelCode { get; set; }

        public virtual ICollection<TaxableType> InverseParentCodeNavigation { get; set; } = new HashSet<TaxableType>();

        public virtual TaxableType ParentCode { get; set; }

        public virtual ICollection<PurchasesTaxInvoice> PurchasesTaxInvoices { get; set; } = new List<PurchasesTaxInvoice>();

        public virtual ICollection<SalesTaxInvoiceFooter> SalesTaxInvoiceFs { get; set; } = new HashSet<SalesTaxInvoiceFooter>();

        public virtual ICollection<SalesTaxInvoiceHeader> SalesTaxInvoiceHs { get; set; } = new HashSet<SalesTaxInvoiceHeader>();
    }
}
