namespace Link_Entities.Models;

public partial class EmployeeDatum
{
    public Guid EmployeeId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public int EmployeeNo { get; set; }

    public string EmployeeName { get; set; }

    public string EmployeeNameL2 { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string EmployeeAddress { get; set; }

    public string NationalId { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateFinsh { get; set; }

    public TimeOnly? TimeStartWork { get; set; }

    public TimeOnly? TimeEndWork { get; set; }

    public DateTime? DateBarith { get; set; }

    public long? RecruitmentDataId { get; set; }

    public string EmployeeMobil { get; set; }

    public string EmployeePhone { get; set; }

    public string EmployeeWhatsapp { get; set; }

    public string EmployeeEmail { get; set; }

    public long? EducationDataId { get; set; }

    public long? UniversityDataId { get; set; }

    public string YareEducation { get; set; }

    public long? EducationeStimateId { get; set; }

    public long? GenderDataId { get; set; }

    public long? SocialDataId { get; set; }

    public int? Aeg { get; set; }

    public string ImageUrl { get; set; }

    public string Description { get; set; }

    public DateOnly? EmployeeCancel { get; set; }

    public Guid? GroupWorkId { get; set; }

    public long? PaymentTypeId { get; set; }

    public double? BasicSalary { get; set; }

    public long? JobDataId { get; set; }

    public long? DepartmentId { get; set; }

    public string AspNetUsersId { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<BranchesData> BranchesData { get; set; } = new List<BranchesData>();

    public virtual BranchesData BranchesDataNavigation { get; set; }

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<ConContractorDatum> ConContractorData { get; set; } = new List<ConContractorDatum>();

    public virtual Department Department { get; set; }

    public virtual EducationDatum EducationData { get; set; }

    public virtual EducationeStimate EducationeStimate { get; set; }

    public virtual ICollection<EmpAccept> EmpAccepts { get; set; } = new List<EmpAccept>();

    public virtual ICollection<EmpAttend> EmpAttends { get; set; } = new List<EmpAttend>();

    public virtual ICollection<EmpContractMaster> EmpContractMasters { get; set; } = new List<EmpContractMaster>();

    public virtual ICollection<EmpLevel> EmpLevels { get; set; } = new List<EmpLevel>();

    public virtual ICollection<EmpLoan> EmpLoans { get; set; } = new List<EmpLoan>();

    public virtual ICollection<EmployeeJob> EmployeeJobs { get; set; } = new List<EmployeeJob>();

    public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; } = new List<EmployeeSkill>();

    public virtual ICollection<FinalDatum> FinalData { get; set; } = new List<FinalDatum>();

    public virtual ICollection<FinalDataFixed> FinalDataFixeds { get; set; } = new List<FinalDataFixed>();

    public virtual GenderDatum GenderData { get; set; }

    public virtual EmpGroupWork GroupWork { get; set; }

    public virtual JobDatum JobData { get; set; }

    public virtual PaymentMode PaymentType { get; set; }

    public virtual ICollection<Possession> Possessions { get; set; } = new List<Possession>();

    public virtual RecruitmentDatum RecruitmentData { get; set; }

    public virtual SocialDatum SocialData { get; set; }

    public virtual ICollection<StoreData> StoreData { get; set; } = new List<StoreData>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new List<SupplierData>();

    public virtual UniversityDatum UniversityData { get; set; }
}
