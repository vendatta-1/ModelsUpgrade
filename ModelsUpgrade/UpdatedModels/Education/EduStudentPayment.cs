using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduStudentPayment : TransactionFooterEntity
{

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StudentDataId { get; set; }

    public Guid? AcademyCourseId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public virtual EduAcademyCourse AcademyCourse { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual EduStudentData StudentData { get; set; }
}
