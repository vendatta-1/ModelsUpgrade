
using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpLoansType : NamedEntity
    {
        public virtual ICollection<EmpLoans> EmpLoans { get; set; } = new HashSet<EmpLoans>();
    }
}
