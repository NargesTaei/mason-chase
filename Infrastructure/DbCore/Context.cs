using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.DbCore
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            base.ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(u => new { u.FirstName , u.LastName, u.DateOfBirth}).IsUnique();
            modelBuilder.Entity<Customer>()
              .Property(e => e.PhoneNumber)
              .HasMaxLength(13);
            base.OnModelCreating(modelBuilder);
        }
    }
}
