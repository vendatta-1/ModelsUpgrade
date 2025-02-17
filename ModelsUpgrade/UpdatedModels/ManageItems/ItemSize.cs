using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.ManageItems
{
    public class ItemSize : Entity
    {
        public Guid? ItemHeaderId { get; set; }

        public Guid? SizeTypeId { get; set; }

        public double? SizeValue { get; set; } = 0.0;


        public virtual ItemsHeader ItemHeader { get; set; }

        public virtual SizeType SizeType { get; set; }
    }
}
