using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class InvoicingResult : Entity
    {
        [MaxLength(50)]
        public string Uuid { get; set; }
        [MaxLength(50)]
        public string LongId { get; set; }
        [MaxLength(50)]
        public string InternalId { get; set; }
        [MaxLength(50)]
        public string HashKey { get; set; }
    }
}
