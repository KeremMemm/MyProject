using BankApplicationForUniser.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplicationForUniser.Configurations;

public class BankCardConfig : IEntityTypeConfiguration<BankCard>
{
    public void Configure(EntityTypeBuilder<BankCard> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn(1, 1);

        builder.Property(x => x.CardNumber)
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(x => x.EndDate)
            .HasDefaultValue(DateTime.Now.AddYears(2));

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.BankCards)
            .HasForeignKey(x => x.CustomerId);

        builder.HasOne(x => x.CardType)
            .WithMany(x => x.BankCards)
            .HasForeignKey(x => x.CardTypeId);


        builder.HasIndex(x => x.CreditId).IsUnique();

        builder.HasOne(x => x.Credit)
            .WithOne(x => x.BankCard)
            .HasForeignKey<BankCard>(x => x.CreditId);


            
    }
}
