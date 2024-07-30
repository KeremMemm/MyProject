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
    internal class CustomerWorkDetailConfig : IEntityTypeConfiguration<CustomerWorkDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerWorkDetail> builder)
        {
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Salary);
            builder.Property(x => x.Experience);
        }
    }
}
