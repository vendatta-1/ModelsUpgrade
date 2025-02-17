
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.EInvoicing
{
    public class CustomerModes : NamedEntity
    {

        public string DocumentType { get; set; } ///// need updates
        public virtual ICollection<CustomerData> CustomerData { get; set; } = new HashSet<CustomerData>();
    }
}
