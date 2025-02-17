using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ClientAccessToken
{
    public long AccessTokenId { get; set; }

    public Guid ClientDataTokenId { get; set; }

    public string AccessToken { get; set; }

    public int? ExpiresIn { get; set; }

    public string TokenType { get; set; }

    public string Scope { get; set; }

    public TimeOnly? CreateTime { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ClientDataToken ClientDataToken { get; set; }
}
