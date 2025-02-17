using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ProgramSetting;

namespace ModelsUpgrade.UpdatedModels.Inventory
{
    public class InventoryValuation : NamedEntity
    {
        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; } = new HashSet<ApplicationSetting>();

    }
}
