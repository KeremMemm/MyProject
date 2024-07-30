using BankApplicationForUniser.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BankApplicationForUniser.Contexts
{
    public class BankCardUniserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BankAccountUniserDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerWorkDetail> CustomerWorkDetails { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
