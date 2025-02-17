
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Contractors;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class SupplierGroup : NamedEntity
    {
        public SupplierGroup(Guid id) : base(id)
        {

        }
        protected SupplierGroup()
        {

        }
        public virtual ICollection<ConContractorData> ConContractorData { get; set; } = new HashSet<ConContractorData>();

        public virtual ICollection<SupplierData> SupplierData { get; set; } = new HashSet<SupplierData>();
    }
}
