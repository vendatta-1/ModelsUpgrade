using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EduStudentPayment
{
    public Guid PaymentId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StudentDataId { get; set; }

    public Guid? AcademyCourseId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual EduAcademyCourse AcademyCourse { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual EduStudentData StudentData { get; set; }
}
