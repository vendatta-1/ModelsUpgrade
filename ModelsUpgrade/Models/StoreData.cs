using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class StoreData
{
    public Guid StoreId { get; set; }

    public int StoreDataId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string StoreName { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string StoreAddress { get; set; }

    public string StoreMobil { get; set; }

    public string StorePhone { get; set; }

    public string StoreWhatsapp { get; set; }

    public string StoreEmail { get; set; }

    public Guid? StoreManager { get; set; }

    public Guid? AccountsNameId { get; set; }

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

    public virtual AccountName AccountsName { get; set; }

    public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new List<AdditionAdjustment>();

    public virtual BranchesData BranchesData { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<InventoryOrderHeader> InventoryOrderHeaders { get; set; } = new List<InventoryOrderHeader>();

    public virtual ICollection<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; } = new List<ItemsBalanceHeader>();

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new List<ItemsStock>();

    public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new List<PAdditionAdjustment>();

    public virtual ICollection<PInventoryOrderHeader> PinventoryOrderHeaders { get; set; } = new List<PInventoryOrderHeader>();

    public virtual ICollection<PItemsBalanceHeader> PitemsBalanceHeaders { get; set; } = new List<PItemsBalanceHeader>();

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new List<PItemsStock>();

    public virtual ICollection<PrequestReceiptHeader> PrequestReceiptHeaders { get; set; } = new List<PrequestReceiptHeader>();

    public virtual ICollection<PsettlementDiscount> PsettlementDiscounts { get; set; } = new List<PsettlementDiscount>();

    public virtual ICollection<RequestReceiptHeader> RequestReceiptHeaders { get; set; } = new List<RequestReceiptHeader>();

    public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new List<SettlementDiscount>();

    public virtual EmployeeDatum StoreManagerNavigation { get; set; }

    public virtual ICollection<TransformationsMaster> TransformationsMasterFroms { get; set; } = new List<TransformationsMaster>();

    public virtual ICollection<TransformationsMaster> TransformationsMasterTos { get; set; } = new List<TransformationsMaster>();
}
