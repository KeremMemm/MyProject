using BankAccountForm.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Configurations.Accounts
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.LastName).IsRequired().HasMaxLength(20);
            builder.Ignore(x => x.FullName);

            builder.HasOne(x => x.CustomerWorkDetail)
                .WithOne(x => x.Customer)
                .HasForeignKey<CustomerWorkDetail>(x => x.CustomerId);

            builder.HasMany(x => x.BankCards)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);
        }
    }
}
