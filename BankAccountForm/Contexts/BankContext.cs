using BankAccountForm.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Contexts
{
    internal class BankContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BankAccountDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerWorkDetail> CustomerWorkDetails { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardType>()
                .HasData(
                        new CardType { Id = 1, Value = "Debet" },
                        new CardType { Id = 2, Value = "Credit" }
                );

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

           
        }
    }
}
