using BankApplicationForUniser.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplicationForUniser.Configurations;

public  class CustomerWorkDetailConfig : IEntityTypeConfiguration<CustomerWorkDetail>
{
    public void Configure(EntityTypeBuilder<CustomerWorkDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.CompanyName)
            .IsRequired()
            .HasMaxLength(30);


        builder.Property(x => x.Salary);
        builder.Property(x => x.Experience);

        builder.HasIndex(x => x.CustomerId)
            .IsUnique();
    }
}
