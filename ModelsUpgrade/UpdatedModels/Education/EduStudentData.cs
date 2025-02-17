using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.ProgramSetting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduStudentData : NamedEntity
{

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }


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

    [MaxLength(75)]
    public string StudentAddress { get; set; }
    [MaxLength(14)]
    public string NationalId { get; set; }
    public Guid? StudentBarCode { get; set; }


    //public DateOnly? DateStart { get; set; }

    //public string DateFinsh { get; set; }
    public Duration StudentDuration { get; set; }

    public string PassportNumber { get; set; }

    //public DateOnly? PassportDateStart { get; set; }

    //public DateOnly? PassportDateFinsh { get; set; }
    public Duration PassportDateInfo { get; set; }

    public DateOnly? DateBirth { get; set; }

    public ContactInfo ContactInfo { get; set; }

    public string YareEducation { get; set; }

    public string? StudentAge { get; set; }

    [MaxLength(250)]
    public string ImageUrl { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual CityCode CityCode { get; set; }
    public virtual ICollection<EduStudentCourse> EduStudentCourses { get; set; } = new HashSet<EduStudentCourse>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new HashSet<EduStudentPayment>();

    public virtual EducationData EducationData { get; set; }

    public virtual EducationStimate EducationeStimate { get; set; }

    public virtual GenderData GenderData { get; set; }

    public virtual RecruitmentData RecruitmentData { get; set; }

    public virtual SocialData SocialData { get; set; }

    public virtual UniversityData UniversityData { get; set; }
    public virtual CompanyData CompanyData { get; set; }
}
