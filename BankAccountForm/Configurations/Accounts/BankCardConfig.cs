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
    public class BankCardConfig : IEntityTypeConfiguration<BankCard>
    {
        public void Configure(EntityTypeBuilder<BankCard> builder)
        {
            builder.Property(x=>x.CardNumber)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.EndDate)
                .IsRequired()
                .HasDefaultValue(DateTime.Now.AddYears(5));


            builder.HasOne(x => x.CardType).WithMany(x => x.BankCards).HasForeignKey(x => x.CardTypeId);
            builder.HasOne(x => x.Credit).WithOne(x => x.BankCard).HasForeignKey<Credit>(x => x.BankCardId);


        }
    }
}
