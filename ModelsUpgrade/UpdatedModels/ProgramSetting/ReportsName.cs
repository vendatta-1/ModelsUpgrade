using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class ReportsName : NamedEntity
    {
        public Guid? ApplicationMenuId { get; set; }
        public virtual ApplicationMenu ApplicationMenu { get; set; }

    }
}
