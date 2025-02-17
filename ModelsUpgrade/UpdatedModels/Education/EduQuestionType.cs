using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduQuestionType : NamedEntity
{

    public virtual ICollection<EduQuestionsMaster> EduQuestionsMasters { get; set; } = new HashSet<EduQuestionsMaster>();
}
