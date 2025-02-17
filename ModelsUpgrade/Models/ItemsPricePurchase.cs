using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ItemsPricePurchase
{
    public Guid ItemsHistoryPurchasesId { get; set; }

    public Guid? ItemsHeaderId { get; set; }

    public Guid? SupplierDataId { get; set; }

    public DateTime? DatePurchases { get; set; }

    public double? ItemsPrice { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ItemsHeader ItemsHeader { get; set; }

    public virtual SupplierData SupplierData { get; set; }
}
