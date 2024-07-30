using BankApplicationForUniser.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplicationForUniser.Configurations
{
    public class CreditConfig : IEntityTypeConfiguration<Credit>
    {
        public void Configure(EntityTypeBuilder<Credit> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Percent).IsRequired();

        }
    }
}
