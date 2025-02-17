using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PRequestReservationHeader : HeaderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReceiptNo { get; set; }


        public DateInfo DateInfo { get; set; }


        public double? TotalValue { get; set; } = 0.0;


        public virtual ICollection<PRequestReservationFooter> PRequestReservationFooters { get; set; } = new HashSet<PRequestReservationFooter>();
    }
}
