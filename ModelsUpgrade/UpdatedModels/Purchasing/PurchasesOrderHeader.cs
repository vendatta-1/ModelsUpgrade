using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class PurchasesOrderHeader : HeaderEntity
    {
        public PurchasesOrderHeader(Guid id) : base(id) { }
        protected PurchasesOrderHeader()
        {

        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNo { get; set; }


        public Guid? SupplierDataId { get; set; }

        public DateInfo DateInfo { get; set; }


        public double? TotalValue { get; set; } = 0.0;



        public virtual ICollection<PurchasesOrderFooter> PurchasesOrderFooters { get; set; } = new HashSet<PurchasesOrderFooter>();

        public virtual SupplierData SupplierData { get; set; }
    }
}
