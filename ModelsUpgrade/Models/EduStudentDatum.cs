using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EduStudentData
{
    public Guid StudentId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StudentBarCode { get; set; }

    public string StudentNameL1 { get; set; }

    public string StudentNameL2 { get; set; }

    public long? CountryCodeId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public long? CityCodeId { get; set; }

    public string StudentAddress { get; set; }

    public string NationalId { get; set; }

    public DateOnly? DateStart { get; set; }

    public string DateFinsh { get; set; }

    public string PassportNumber { get; set; }

    public DateOnly? PassportDateStart { get; set; }

    public DateOnly? PassportDateFinsh { get; set; }

    public DateOnly? DateBirth { get; set; }

    public long? RecruitmentDataId { get; set; }

    public string StudentMobil { get; set; }

    public string StudentPhone { get; set; }

    public string StudentWhatsapp { get; set; }

    public string StudentEmail { get; set; }

    public long? EducationDataId { get; set; }

    public long? UniversityDataId { get; set; }

    public string YareEducation { get; set; }

    public long? EducationeStimateId { get; set; }

    public long? GenderDataId { get; set; }

    public long? SocialDataId { get; set; }

    public int? StudentAeg { get; set; }

    public string ImageUrl { get; set; }

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

    public virtual CityCode CityCode { get; set; }

    public virtual ICollection<EduStudentCourse> EduStudentCourses { get; set; } = new List<EduStudentCourse>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new List<EduStudentPayment>();

    public virtual EducationDatum EducationData { get; set; }

    public virtual EducationeStimate EducationeStimate { get; set; }

    public virtual GenderDatum GenderData { get; set; }

    public virtual RecruitmentDatum RecruitmentData { get; set; }

    public virtual SocialDatum SocialData { get; set; }

    public virtual UniversityDatum UniversityData { get; set; }
}
