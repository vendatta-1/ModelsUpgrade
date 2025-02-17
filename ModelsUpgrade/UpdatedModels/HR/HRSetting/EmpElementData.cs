
using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpElementData : NamedEntity
    {
        public Guid? EmpElemntNaturId { get; set; }

        public Guid? EmpElemntTypeId { get; set; }

        public bool? MonthNotActive { get; set; }

        public virtual ICollection<EmpContractFooter> EmpContractDetalis { get; set; } = new List<EmpContractFooter>();

        public virtual EmpElementNature EmpElemntNature { get; set; }

        public virtual EmpElementType EmpElemntType { get; set; }

    }
}
