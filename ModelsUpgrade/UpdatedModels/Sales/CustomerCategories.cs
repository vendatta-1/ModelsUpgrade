using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class CustomerCategories : NamedEntity
    {
        public CustomerCategories(Guid id) : base(id)
        {

        }
        protected CustomerCategories()
        {

        }
        public virtual ICollection<CustomerData> CustomerData { get; set; } = new HashSet<CustomerData>();
    }
}
