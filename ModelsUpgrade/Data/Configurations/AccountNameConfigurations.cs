using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;

namespace ModelsUpgrade.Data.Configurations
{
    public sealed class AccountNameConfigurations : IEntityTypeConfiguration<AccountName>
    {
        public void Configure(EntityTypeBuilder<AccountName> builder)
        {
            builder.HasMany(acc => acc.AccountFixedDetailAccountNames)
                 .WithOne(acc => acc.AccountName)
                 .HasForeignKey(acc => acc.AccountNameId);

            builder.HasMany(acc => acc.AccountFixedDetailAccountNameLevel2s)
                 .WithOne(acc => acc.AccountNameLevel2)
                 .HasForeignKey(acc => acc.AccountNameLevel2Id);

            builder.HasMany(acc => acc.CheckDetailAccountNameFromNavigations)
                .WithOne(acc => acc.AccountNameFrom)
                .HasForeignKey(acc => acc.AccountNameFromId);

            builder.HasMany(acc => acc.CheckDetailAccountNameToNavigations)
                .WithOne(acc => acc.AccountNameTo)
                .HasForeignKey(acc => acc.AccountNameToId);

            builder.HasMany(acc => acc.MoneyPaymentFromAccountNames)
                .WithOne(acc => acc.FromAccountName)
                .HasForeignKey(acc => acc.FromAccountNameId);

            builder.HasMany(acc => acc.MoneyPaymentToAccountNames)
                .WithOne(acc => acc.ToAccountName)
                .HasForeignKey(acc => acc.ToAccountNameId);

            builder.HasMany(acc => acc.MoneyReceiveFromAccountNames)
                .WithOne(acc => acc.FromAccountName)
                .HasForeignKey(acc => acc.FromAccountNameId);

            builder.HasMany(acc => acc.MoneyReceiveToAccountNames)
                .WithOne(acc => acc.ToAccountName)
                .HasForeignKey(acc => acc.ToAccountNameId);

            builder.HasMany(acc => acc.PitemsHeaderAccountNameSales)
                .WithOne(it => it.AccountNameSales)
                .HasForeignKey(it => it.AccountNameSalesId);

            builder.HasMany(acc => acc.PitemsHeaderAccountsNamePurchas)
                .WithOne(it => it.AccountsNamePurchas)
                .HasForeignKey(it => it.AccountsNamePurchasId);
            builder.HasOne(x => x.ParentCodeNavigation)
                .WithMany()
                .HasForeignKey(x => x.ParentCode)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
