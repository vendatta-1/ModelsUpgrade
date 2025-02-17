using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EduAcademyCourse
{
    public Guid CourseId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public string CourseName { get; set; }

    public Guid? ParentCourse { get; set; }

    public int? CourseLeavel { get; set; }

    public double? CourseValue { get; set; }

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

    public virtual ICollection<EduQuestionsMaster> EduQuestionsMasters { get; set; } = new List<EduQuestionsMaster>();

    public virtual ICollection<EduStudentPayment> EduStudentPayments { get; set; } = new List<EduStudentPayment>();

    public virtual ICollection<EduAcademyCourse> InverseParentCourseNavigation { get; set; } = new List<EduAcademyCourse>();

    public virtual EduAcademyCourse ParentCourseNavigation { get; set; }
}
