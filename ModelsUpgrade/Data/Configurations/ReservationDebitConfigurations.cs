using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

namespace ModelsUpgrade.Data.Configurations
{
    public class ReservationDebitConfigurations : IEntityTypeConfiguration<ReservationDebit>
    {
        public void Configure(EntityTypeBuilder<ReservationDebit> builder)
        {
        }
    }
}
