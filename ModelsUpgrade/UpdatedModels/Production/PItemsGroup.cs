using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PItemsGroup : NamedEntity
    {
        public Guid? CompanyDataId { get; set; }
        [MaxLength(20)]
        public string ItemCodeTax { get; set; }

        public Guid? ParentCode { get; set; }

        public int? LevelCode { get; set; } = 0;
        public virtual CompanyData CompanyData { get; set; }

        public virtual ICollection<PItemsGroup> InverseParentCodeNavigation { get; set; } = new List<PItemsGroup>();

        public virtual PItemsGroup ParentCodeNavigation { get; set; }

        public virtual ICollection<PItemsHeader> PItemsHeaders { get; set; } = new HashSet<PItemsHeader>();
    }
}
