using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;

namespace ModelsUpgrade.UpdatedModels.ManageItems
{
    public class ItemsColor : Entity
    {



        public Guid? ItemHeaderId { get; set; }

        public Guid? SizeTypeId { get; set; }

        public Guid? ColorTypeId { get; set; }

        public virtual ColorType ColorType { get; set; }

        public virtual ItemsHeader ItemHeader { get; set; }

        public virtual SizeType SizeType { get; set; }
    }
}
