using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class ApplicationSetting
{
    public Guid SettimgId { get; set; }

    public long SettingNumber { get; set; }

    public Guid? CompanyDataId { get; set; }

    public long? CountryCodeId { get; set; }

    public long? InventoryValuationId { get; set; }

    public bool? AccountNumberActivate { get; set; }

    public string AccountNumberValue { get; set; }

    public bool? BarCodeItems { get; set; }

    public string BarCodeStartValue { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual CountryCode CountryCode { get; set; }

    public virtual InventoryValuation InventoryValuation { get; set; }
}
