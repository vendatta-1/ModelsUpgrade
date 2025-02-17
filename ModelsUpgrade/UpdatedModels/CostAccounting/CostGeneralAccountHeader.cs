using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;

namespace ModelsUpgrade.UpdatedModels.CostAccounting
{
    public class CostGeneralAccountHeader : DatedInfoEntity
    {


        public Guid? CurrencyDataId { get; set; }

        public virtual ICollection<CostGeneralAccountFooter> CostGeneralAccountFooters { get; set; } = new HashSet<CostGeneralAccountFooter>();

        public virtual CurrencyData CurrencyData { get; set; }
    }
}
