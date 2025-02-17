using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Education.EducationValueObjs;
namespace ModelsUpgrade.UpdatedModels.Education;

public class EduQuestionsMaster : Entity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? AcademyCourseId { get; set; }

    public Guid? QuestionTypeId { get; set; }
    public QuestionMasterInfo QuestionInfo { get; set; }


    public virtual EduAcademyCourse AcademyCourse { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual ICollection<EduQuestionDetail> EduQuestionDetails { get; set; } = new HashSet<EduQuestionDetail>();

    public virtual EduQuestionType QuestionType { get; set; }
}
