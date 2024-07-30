using BankApplicationForUniser.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplicationForUniser.Configurations
{
    public class CardTypeConfig : IEntityTypeConfiguration<CardType>
    {
        public void Configure(EntityTypeBuilder<CardType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasData(
                    new CardType { Id =1 , Value = "Debet"},
                    new CardType { Id =2 , Value = "Credit"}
                );
        }
    }
}
