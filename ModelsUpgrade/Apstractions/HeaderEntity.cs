using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.Apstractions
{
    public abstract class HeaderEntity : Entity
    {
        public bool IsPosted { get; set; } = true;
        protected HeaderEntity() { }
        public HeaderEntity(Guid id) : base(id) { }
        public Guid CompanyDataId { get; set; }
        public Guid BranchesDataId { get; set; }
        public string Description { get; set; } = string.Empty;
        public virtual CompanyData CompanyData { get; set; }
        public virtual BranchesData BranchesData { get; set; }
    }
}
