using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ModelsUpgrade.Apstractions;
using System.Reflection;

namespace ModelsUpgrade.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LinkDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            var assembly = Assembly.GetExecutingAssembly();
            var entities = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Entity)));

            foreach (var entity in entities)
            {
                modelBuilder.Entity(entity);
            }

            ApplyNoActionForCyclicRelationships(modelBuilder);

            SetDefaultValuesForNumericProperties(modelBuilder);
        }

        private void ApplyNoActionForCyclicRelationships(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entityType.GetForeignKeys())
                {

                    if (IsCyclic(foreignKey))
                    {
                        foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
                    }
                }
            }
        }


        private bool IsCyclic(IMutableForeignKey foreignKey)
        {
            var principalEntityType = foreignKey.PrincipalEntityType;
            var dependentEntityType = foreignKey.DeclaringEntityType;

            if (principalEntityType == dependentEntityType)
            {
                return true;
            }

            return false;
        }

        private void SetDefaultValuesForNumericProperties(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {

                    if (IsNumericType(property.ClrType))
                    {
                        property.SetDefaultValueSql("0");
                    }
                }
            }
        }

        private bool IsNumericType(Type type)
        {
            return
                   type == typeof(int?) || type == typeof(long?) || type == typeof(short?) || type == typeof(byte?) ||
                   type == typeof(decimal?) || type == typeof(double?) || type == typeof(float?);
        }
    }
}
