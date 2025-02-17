using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class ClientDataToken : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret1 { get; set; }

        public string ClientSecret2 { get; set; }
        public virtual CompanyData CompanyData { get; set; }
        public virtual BranchesData BranchesData { get; set; }
        public virtual ICollection<ClientAccessToken> ClientAccessTokens { get; set; } = new HashSet<ClientAccessToken>();
    }
}
