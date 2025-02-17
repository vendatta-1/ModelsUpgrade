using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.Apstractions
{
    public abstract class Entity : IEquatable<Entity>
    {

        public Guid Id { get; init; }
        protected Entity(Guid id)
        {
            Id = id;
        }
        protected Entity() { }

        public bool? IsNotActive { get; set; } = true;

        [MaxLength(50)]
        public string CreatedUserId { get; set; }
        [MaxLength(50)]

        public string CreatedUserName { get; set; }

        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(50)]

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsDeleted { get; set; } = true;

        [MaxLength(50)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }


        public bool Equals(Entity? other)
        {
            if (other == null) return false;
            return Id == other.Id;
        }
    }
}
