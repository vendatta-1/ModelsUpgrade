using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class RntReceiptsHeader
{
    public Guid ReceiptId { get; set; }

    public int ReceiptCode { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? ContractsId { get; set; }

    public long? CurrencyDataId { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string Description { get; set; }

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

    public virtual RntContractsH Contracts { get; set; }

    public virtual CurrencyDatum CurrencyData { get; set; }

    public virtual ICollection<RntReceiptsD> RntReceiptsDs { get; set; } = new List<RntReceiptsD>();
}
