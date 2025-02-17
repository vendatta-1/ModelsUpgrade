using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class ClientAccessToken : Entity
    {

        public Guid ClientDataTokenId { get; set; }

        public string AccessToken { get; set; }

        public int? ExpiresIn { get; set; }
        [MaxLength(20)]
        public string TokenType { get; set; }
        [MaxLength(20)]
        public string Scope { get; set; }

        public TimeOnly? CreateTime { get; set; }

        public virtual ClientDataToken ClientDataToken { get; set; }

    }
}
