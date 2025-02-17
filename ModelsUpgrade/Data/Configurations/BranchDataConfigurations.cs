using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.Data.Configurations
{
    public sealed class BranchDataConfigurations : IEntityTypeConfiguration<BranchesData>
    {
        public void Configure(EntityTypeBuilder<BranchesData> builder)
        {
            builder.HasOne(x => x.BranchManager)
                .WithMany(x => x.BranchesData)
                .HasForeignKey(x => x.BranchManagerId);
            //builder.OwnsOne(x => x.BranchContactInfo);
            //builder.OwnsOne(x => x.Address);

        }
    }
}
