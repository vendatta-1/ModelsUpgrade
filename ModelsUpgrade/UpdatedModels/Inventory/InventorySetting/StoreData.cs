using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.Inventory.InventoryReports;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
public class StoreData : Entity
{
    public StoreData(Guid id) : base(id)
    {

    }
    protected StoreData()
    {

    }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StoreDataId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string StoreName { get; set; }

    public Guid? CountryCodeId { get; set; }

    public Guid? GovernorateCodeId { get; set; }

    public Guid? CityCodeId { get; set; }

    [MaxLength(250)]
    public string Address { get; set; }
    public ContactInfo ContactInformation { get; set; }

    public Guid? StoreManager { get; set; }

    public Guid? AccountsNameId { get; set; }

    public string Description { get; set; }


    public virtual AccountName AccountsName { get; set; }

    public virtual ICollection<AdditionAdjustment> AdditionAdjustments { get; set; } = new HashSet<AdditionAdjustment>();

    public virtual BranchesData BranchesData { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<InventoryOrderHeader> InventoryOrderHeaders { get; set; } = new HashSet<InventoryOrderHeader>();

    public virtual ICollection<ItemsBalanceHeader> ItemsBalanceHeaders { get; set; } = new HashSet<ItemsBalanceHeader>();

    public virtual ICollection<ItemsStock> ItemsStocks { get; set; } = new HashSet<ItemsStock>();

    public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new HashSet<PAdditionAdjustment>();

    public virtual ICollection<PInventoryOrderHeader> PinventoryOrderHeaders { get; set; } = new HashSet<PInventoryOrderHeader>();

    public virtual ICollection<PItemsBalanceHeader> PitemsBalanceHeaders { get; set; } = new HashSet<PItemsBalanceHeader>();

    public virtual ICollection<PItemsStock> PitemsStocks { get; set; } = new HashSet<PItemsStock>();

    public virtual ICollection<PRequestReceiptHeader> PrequestReceiptHeaders { get; set; } = new HashSet<PRequestReceiptHeader>();

    public virtual ICollection<PSettlementDiscount> PsettlementDiscounts { get; set; } = new HashSet<PSettlementDiscount>();

    public virtual ICollection<RequestReceiptHeader> RequestReceiptHeaders { get; set; } = new HashSet<RequestReceiptHeader>();

    public virtual ICollection<SettlementDiscount> SettlementDiscounts { get; set; } = new HashSet<SettlementDiscount>();

    public virtual EmployeeData StoreManagerNavigation { get; set; }

    public virtual ICollection<TransformationsMaster> TransformationsMasterFroms { get; set; } = new HashSet<TransformationsMaster>();

    public virtual ICollection<TransformationsMaster> TransformationsMasterTos { get; set; } = new HashSet<TransformationsMaster>();
}
