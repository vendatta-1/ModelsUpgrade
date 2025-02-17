using ModelsUpgrade.Apstractions;


namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting
{
    public class SizeType : NamedEntity
    {
        public virtual ICollection<ItemsColor> ItemsColors { get; set; } = new HashSet<ItemsColor>();

        public virtual ICollection<ItemSize> ItemsSizes { get; set; } = new HashSet<ItemSize>();
    }
}
