using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Production;

namespace ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting
{
    public class ItemsType : NamedEntity
    {
        public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new HashSet<ItemsHeader>();

        public virtual ICollection<PItemsHeader> PitemsHeaders { get; set; } = new HashSet<PItemsHeader>();
    }
}
