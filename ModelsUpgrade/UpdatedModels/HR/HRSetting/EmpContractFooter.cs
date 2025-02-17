using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpContractFooter : FooterEntity
    {
        public Guid? EmpContractHid { get; set; }

        public Guid? EmpElementTypeId { get; set; }

        public Guid? EmpElementDataId { get; set; }

        public double? ValueElment { get; set; } = 0.0;


        public virtual EmpContractHeader EmpContractH { get; set; }

        public virtual EmpElementData EmpElementData { get; set; }

        public virtual EmpElementType EmpElementType { get; set; }
    }
}
