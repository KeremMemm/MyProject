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
    internal class CreditConfig : IEntityTypeConfiguration<Credit>
    {
        public void Configure(EntityTypeBuilder<Credit> builder)
        {
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x=>x.Percent).IsRequired();


        }
    }
}
