using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class ActivityCode : NamedEntity
    {
        public bool? IsPosted { get; set; } = true;
        public int? CodeTax { get; set; } = 0;
    }
}
