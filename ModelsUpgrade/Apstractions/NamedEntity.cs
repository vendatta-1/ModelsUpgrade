namespace ModelsUpgrade.Apstractions
{
    public abstract class NamedEntity : Entity
    {
        protected NamedEntity(Guid id) : base(id) { }
        protected NamedEntity()
        {

        }
        public required string NameL1 { get; set; }
        public string? NameL2 { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
