using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class AspNetUser
{
    public string Id { get; set; }

    public Guid? CompanyDataId { get; set; }

    public long? BankCodeId { get; set; }

    public string UserName { get; set; }

    public string NormalizedUserName { get; set; }

    public string Email { get; set; }

    public string NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string PasswordHash { get; set; }

    public string SecurityStamp { get; set; }

    public string ConcurrencyStamp { get; set; }

    public string PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; } = new List<AspNetUserToken>();

    public virtual ICollection<AspPermission> AspPermissions { get; set; } = new List<AspPermission>();

    public virtual BankCode BankCode { get; set; }

    public virtual ICollection<WorkPlanFooter> WorkPlanFooters { get; set; } = new List<WorkPlanFooter>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
