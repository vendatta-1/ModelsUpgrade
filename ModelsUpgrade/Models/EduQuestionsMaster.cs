using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class EduQuestionsMaster
{
    public Guid QuestionMasterId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? AcademyCourseId { get; set; }

    public long? QuestionTypeId { get; set; }

    public string QuestionDetails { get; set; }

    public string QuestionAnswer { get; set; }

    public int? QuestionValue { get; set; }

    public string Description { get; set; }

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

    public virtual ICollection<EduQuestionDetail> EduQuestionDetails { get; set; } = new List<EduQuestionDetail>();

    public virtual EduQuestionType QuestionType { get; set; }
}
