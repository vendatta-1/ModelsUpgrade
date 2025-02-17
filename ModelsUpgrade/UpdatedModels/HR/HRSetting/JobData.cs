
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Medical;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class JobData : NamedEntity
    {
        public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();

        public virtual ICollection<MedPartnerData> MedPartnerData { get; set; } = new HashSet<MedPartnerData>();

    }
}
