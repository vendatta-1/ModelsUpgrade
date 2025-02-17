using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class HomePage
{
    public long HomeId { get; set; }

    public string HeaderText { get; set; }

    public string CardTextRight { get; set; }

    public string CardTextLeft { get; set; }

    public string FooterText { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
