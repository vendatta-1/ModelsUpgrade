using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;

namespace ModelsUpgrade.UpdatedModels.CostAccounting
{
    public class CostJournalHeader : DatedInfoEntity
    {
        public CostJournalHeader(Guid id) : base(id) { }
        protected CostJournalHeader()
        {
        }




        public Guid? CurrencyDataId { get; set; }



        public virtual ICollection<CostJournalFooter> CostJournalFooters { get; set; } = new HashSet<CostJournalFooter>();

        public virtual CurrencyData CurrencyData { get; set; }
    }
}
