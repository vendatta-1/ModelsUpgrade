using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting
{
    public class ColorType : NamedEntity
    {
        public virtual ICollection<ItemsColor> ItemsColors { get; set; } = new List<ItemsColor>();

    }
}
