

using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.ManageItems
{
    public class ItemsGroup : NamedEntity
    {


        public Guid? CompanyDataId { get; set; }


        public string ItemCodeTax { get; set; }

        public Guid? ParentCode { get; set; }

        public int? LevelCode { get; set; } = 0;

        public virtual CompanyData CompanyData { get; set; }

        public virtual ICollection<ItemsGroup> InverseParentCodeNavigation { get; set; } = new HashSet<ItemsGroup>();

        public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new List<ItemsHeader>();

        public virtual ItemsGroup ParentCodeNavigation { get; set; }
    }
}
