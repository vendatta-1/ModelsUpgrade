namespace TestApplication
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public int SharedId { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public virtual Shared Shared { get; set; }
    }
}
