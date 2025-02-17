using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpElementType : NamedEntity
    {
        public virtual ICollection<EmpContractFooter> EmpContractDetalis { get; set; } = new HashSet<EmpContractFooter>();

        public virtual ICollection<EmpElementData> EmpElementData { get; set; } = new HashSet<EmpElementData>();
    }
}
