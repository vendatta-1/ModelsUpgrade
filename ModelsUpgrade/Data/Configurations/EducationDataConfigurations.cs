using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;

namespace ModelsUpgrade.Data.Configurations
{
    public class EducationDataConfigurations : IEntityTypeConfiguration<EducationData>
    {
        public void Configure(EntityTypeBuilder<EducationData> builder)
        {

        }
    }
}
