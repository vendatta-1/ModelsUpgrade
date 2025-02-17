using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduQuestionDetail : Entity
{


    public Guid? QuestionsMasterId { get; set; }
    [MaxLength(500)]
    public string QuestionsAnswer { get; set; }

    public bool? AnswerCheck { get; set; }

    public virtual EduQuestionsMaster QuestionsMaster { get; set; }
}
