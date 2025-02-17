using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class APIURLTaxServer : Entity
    {
        [MaxLength(30)]
        public string APIName { get; set; }
        [MaxLength(100)]
        public string APIURLtax { get; set; }

        public int? ServerTypeId { get; set; }

        public int? APIURLTaxPostmanId { get; set; }
    }
}
