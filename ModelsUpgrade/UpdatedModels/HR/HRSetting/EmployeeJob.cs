using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmployeeJob : NamedEntity
    {
        public Guid? EmployeeDataId { get; set; }

        //public DateOnly? FromDate { get; set; }

        //public DateOnly? ToDate { get; set; }
        public Duration JobDuration { get; set; }

        [MaxLength(50)]
        public string CompanyName { get; set; }

        [MaxLength(12)]
        public string Time { get; set; }

        public double? PayrollValue { get; set; } = 0.0;

        public EmployeeData EmployeeData { get; set; }
    }
}
