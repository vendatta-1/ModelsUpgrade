using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class ItemsCodeType : NamedEntity
    {
        public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new HashSet<ItemsHeader>();

    }
}
