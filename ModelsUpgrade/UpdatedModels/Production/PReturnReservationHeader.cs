using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PReturnReservationHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReceiptNo { get; set; }




        public DateInfo DateInfo { get; set; }

        public double? TotalValue { get; set; }

        public virtual ICollection<PReturnReservationFooter> PReturnReservationFooters { get; set; } = new HashSet<PReturnReservationFooter>();
    }
}
