using Microsoft.EntityFrameworkCore;

namespace TestApplication
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TestAbstraction;TrustedConnection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Shared> Shareds { get; set; }
    }
}
