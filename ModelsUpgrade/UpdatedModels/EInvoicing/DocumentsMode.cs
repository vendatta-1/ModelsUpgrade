
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class DocumentsMode : NamedEntity
    {
        [MaxLength(2)]
        public string DocumentType { get; set; }
        [MaxLength(3)]
        public string DocumentTypeVersion { get; set; }

        //public string DocumentTypeName { get; set; } use name L1 and L2


        public virtual ICollection<PReturnPurchasesHeader> PreturnPurchasesHeaders { get; set; } = new HashSet<PReturnPurchasesHeader>();

        public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new HashSet<PurchasesInvoiceHeader>();

        public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new HashSet<ReturnPurchasesHeader>();

        public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new HashSet<ReturnSalesHeader>();

        public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new HashSet<SalesInvoiceHeader>();
    }
}
