

using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.Contractors;
using ModelsUpgrade.UpdatedModels.HR.HRSetting.HRSettingValueObjs;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.POSCasher;
using ModelsUpgrade.UpdatedModels.ProgramSetting;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmployeeData : NamedEntity
    {

        public Guid? CompanyDataId { get; set; }
        [ForeignKey(nameof(BranchesDataNavigation))]
        public Guid? BranchesDataId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeNo { get; set; }
        //[MaxLength(25)]
        //public string EmployeeName { get; set; }

        public Guid? CountryCodeId { get; set; }

        public Guid? GovernorateCodeId { get; set; }

        public Guid? CityCodeId { get; set; }

        public Guid? RecruitmentDataId { get; set; }
        [ForeignKey(nameof(EducationData))]
        public Guid? EducationDataId { get; set; }

        public Guid? UniversityDataId { get; set; }

        public Guid? EducationeStimateId { get; set; }

        public Guid? GenderDataId { get; set; }

        public Guid? SocialDataId { get; set; }

        public Guid? PaymentTypeId { get; set; }
        public Guid? JobDataId { get; set; }

        public Guid? DepartmentId { get; set; }

        public double? BasicSalary { get; set; } = 0.0;

        public string? Age { get; set; }

        public string ImageUrl { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(100)]
        public string EmployeeAddress { get; set; }
        [MaxLength(14)]

        public string NationalId { get; set; }

        public string YareEducation { get; set; }

        public EmployeeTimeInfo? EmployeeTimeInfo { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public virtual ICollection<BranchesData> BranchesData { get; set; } = new HashSet<BranchesData>();

        public virtual BranchesData BranchesDataNavigation { get; set; }

        public virtual CityCode CityCode { get; set; }

        public virtual ICollection<ConContractorData> ConContractorData { get; set; } = new HashSet<ConContractorData>();

        public virtual Department Department { get; set; }

        public virtual EducationData EducationData { get; set; }

        public virtual EducationStimate EducationStimate { get; set; }

        public virtual ICollection<EmpAccept> EmpAccepts { get; set; } = new HashSet<EmpAccept>();

        public virtual ICollection<EmpAttend> EmpAttends { get; set; } = new HashSet<EmpAttend>();

        public virtual ICollection<EmpContractHeader> EmpContractMasters { get; set; } = new HashSet<EmpContractHeader>();

        public virtual ICollection<EmpLevel> EmpLevels { get; set; } = new HashSet<EmpLevel>();

        public virtual ICollection<EmpLoans> EmpLoans { get; set; } = new HashSet<EmpLoans>();

        public virtual ICollection<EmployeeJob> EmployeeJobs { get; set; } = new HashSet<EmployeeJob>();

        public virtual ICollection<EmployeeSkills> EmployeeSkills { get; set; } = new HashSet<EmployeeSkills>();

        public virtual ICollection<FinalData> FinalData { get; set; } = new HashSet<FinalData>();

        public virtual ICollection<FinalDataFixed> FinalDataFixeds { get; set; } = new HashSet<FinalDataFixed>();

        public virtual GenderData GenderData { get; set; }

        public virtual EmpGroupWork GroupWork { get; set; }

        public virtual JobData JobData { get; set; }

        public virtual PaymentMode PaymentType { get; set; }

        public virtual ICollection<PosSession> Possessions { get; set; } = new HashSet<PosSession>();

        public virtual RecruitmentData RecruitmentData { get; set; }

        public virtual SocialData SocialData { get; set; }

        public virtual ICollection<StoreData> StoreData { get; set; } = new HashSet<StoreData>();

        public virtual ICollection<SupplierData> SupplierData { get; set; } = new HashSet<SupplierData>();

        public virtual UniversityData UniversityData { get; set; }
    }
}
