using BankApplicationForUniser.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplicationForUniser.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.FirstName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.LastName)
             .HasMaxLength(20)
             .IsRequired();

            builder.Ignore(x => x.FullName);

            builder.HasOne(x => x.CustomerWorkDetail)
                .WithOne(x => x.Customer)
                .HasForeignKey<CustomerWorkDetail>(x => x.CustomerId);
        }
    }
}
