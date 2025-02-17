using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EduStudentCourse
{
    public Guid StudentCourseId { get; set; }

    public Guid? StudentDataId { get; set; }

    public Guid? AcademyCourseId { get; set; }

    public DateOnly? StartDate { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual EduStudentData StudentData { get; set; }
}
