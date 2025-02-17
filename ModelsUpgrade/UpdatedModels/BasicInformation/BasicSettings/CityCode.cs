using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BankSystem;
using ModelsUpgrade.UpdatedModels.BankSystem.WorkPlan;
using ModelsUpgrade.UpdatedModels.Contractors;
using ModelsUpgrade.UpdatedModels.Education;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.Medical;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
public class CityCode : NamedEntity
{
    public CityCode(Guid id) : base(id)
    {

    }
    protected CityCode() { }

    public Guid? GovernorateCodeId { get; set; }



    public bool? IsPosted { get; set; }

    public virtual GovernorateCode GovernorateCode { get; set; }


    public virtual ICollection<BankAtm> BankAtms { get; set; } = new HashSet<BankAtm>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new HashSet<BankCode>();

    public virtual ICollection<BranchesData> BranchesData { get; set; } = new HashSet<BranchesData>();

    public virtual ICollection<CompanyData> CompanyData { get; set; } = new HashSet<CompanyData>();

    public virtual ICollection<ConContractorData> ConContractorData { get; set; } = new HashSet<ConContractorData>();

    public virtual ICollection<CustomerData> CustomerData { get; set; } = new HashSet<CustomerData>();

    public virtual ICollection<DelegateData> DelegateData { get; set; } = new HashSet<DelegateData>();

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new HashSet<EduStudentData>();

    public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();


    public virtual ICollection<MedPartnerData> MedPartnerData { get; set; } = new HashSet<MedPartnerData>();

    public virtual ICollection<StoreData> StoreData { get; set; } = new HashSet<StoreData>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new HashSet<SupplierData>();

    public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new HashSet<WorkPlanHeader>();
}
