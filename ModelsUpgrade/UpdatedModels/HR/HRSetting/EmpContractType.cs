using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpContractType : NamedEntity
    {
        public virtual ICollection<EmpContractHeader> EmpContractMasters { get; set; } = new HashSet<EmpContractHeader>();

    }
}
