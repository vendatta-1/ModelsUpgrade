using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduStudentCourse : Entity
{


    public Guid? StudentDataId { get; set; }

    public Guid? AcademyCourseId { get; set; }

    public Duration CourseDuration { get; set; }

    public virtual EduStudentData StudentData { get; set; }
}
