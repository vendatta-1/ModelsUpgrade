using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Education;

public class EduAcademyCourse : NamedEntity
{

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    [ForeignKey(nameof(ParentCourse))]
    public Guid? ParentCourseId { get; set; }

    public int? CourseLeavel { get; set; }

    public double? CourseValue { get; set; }
    public virtual BranchesData BranchesData { get; set; }
    public virtual EduAcademyCourse ParentCourse { get; set; }






    public virtual ICollection<EduQuestionsMaster> EduQuestionsMasters { get; set; } = new HashSet<EduQuestionsMaster>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new HashSet<EduStudentPayment>();

    public virtual ICollection<EduAcademyCourse> InverseParentCourseNavigation { get; set; } = new HashSet<EduAcademyCourse>();

}
