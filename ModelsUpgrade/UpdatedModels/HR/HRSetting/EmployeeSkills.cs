using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmployeeSkills : Entity
    {
        public Guid? EmployeeDataId { get; set; }
        [MaxLength(255)]
        public string SkillsName { get; set; }

        public string Descriptions { get; set; }
        [MaxLength(20)]
        public string Darega { get; set; }

        public virtual EmployeeData EmployeeData { get; set; }
    }
}
