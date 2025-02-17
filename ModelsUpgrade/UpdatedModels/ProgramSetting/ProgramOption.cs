using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class ProgramOption : Entity
    {
        public Guid? ApplicationMenuId { get; set; }

        public string Description { get; set; }
        public virtual ApplicationMenu ApplicationMenu { get; set; }

    }
}
