using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.HR.HRSetting
{
    public class EmpAcceptType : NamedEntity
    {
        public virtual ICollection<EmpAccept> EmpAccepts { get; set; } = new HashSet<EmpAccept>();
    }
}
