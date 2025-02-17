using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EduStudentQuestion
{
    public Guid StudentQuestionId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StudentDataId { get; set; }

    public Guid? QuestionsAnswerId { get; set; }

    public string StudentAnswer { get; set; }

    public int? QuestionValue { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
