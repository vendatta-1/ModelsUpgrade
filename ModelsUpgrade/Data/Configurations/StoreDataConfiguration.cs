using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;

namespace ModelsUpgrade.Data.Configurations
{
    public class StoreDataConfiguration : IEntityTypeConfiguration<StoreData>
    {
        public void Configure(EntityTypeBuilder<StoreData> builder)
        {
            builder.HasMany(x => x.TransformationsMasterFroms)
                .WithOne(x => x.From)
                .HasForeignKey(x => x.FromId);

            builder.HasMany(x => x.TransformationsMasterTos)
             .WithOne(x => x.To)
             .HasForeignKey(x => x.ToId);
        }
    }
}
