using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsUpgrade.UpdatedModels.Production;

namespace ModelsUpgrade.Data.Configurations
{
    public class PInventoryOrderFooterConfigurations : IEntityTypeConfiguration<PInventoryOrderFooter>
    {
        public void Configure(EntityTypeBuilder<PInventoryOrderFooter> builder)
        {
            builder.HasOne(x => x.InventoryOrderHeader)
                .WithMany(x => x.PinventoryOrderFooters)
                .HasForeignKey(x => x.PInventoryHeaderId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
