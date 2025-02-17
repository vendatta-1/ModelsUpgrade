using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduStudentQuestion : Entity
{

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StudentDataId { get; set; }

    public Guid? QuestionsAnswerId { get; set; }

    public string StudentAnswer { get; set; }

    public int? QuestionValue { get; set; } = 0;

    public virtual EduStudentData StudentData { get; set; }
    public virtual EduQuestionDetail QuestionAnswer { get; set; }


}
