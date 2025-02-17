namespace Link_Entities.Models;

public partial class ClientDataToken
{
    public Guid ClientDataTokenId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string ClientId { get; set; }

    public string ClientSecret1 { get; set; }

    public string ClientSecret2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<ClientAccessToken> ClientAccessTokens { get; set; } = new List<ClientAccessToken>();
}
