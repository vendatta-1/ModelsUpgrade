using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmployeeCourse : Entity
    {
        //[Column("PK_EmployeeDetails")]
        //public new Guid Id { get; set; }
        public Guid? EmployeeDataId { get; set; }
        [MaxLength(100)]
        public string CourseName { get; set; }

        public string Description { get; set; }
        [MaxLength(200)]
        public string Years { get; set; }
        [MaxLength(100)]
        public string Academy { get; set; }
        public EmployeeData EmployeeData { get; set; }
    }
}
