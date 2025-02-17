using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpElementNature : NamedEntity
    {
        public virtual ICollection<EmpElementData> EmpElementsData { get; set; } = new List<EmpElementData>();
    }
}
