using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class RequestReservationHeader : HeaderEntity
    {
        public RequestReservationHeader(Guid id) : base(id)
        {

        }
        protected RequestReservationHeader()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiptNo { get; set; }


        public DateInfo DateInfo { get; set; }


        public double? TotalValue { get; set; }

        public virtual ICollection<RequestReservationFooter> RequestReservationFooters { get; set; } = new HashSet<RequestReservationFooter>();

        public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new HashSet<SalesInvoiceHeader>();
    }
}
