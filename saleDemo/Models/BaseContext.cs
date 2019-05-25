using System;
using Microsoft.EntityFrameworkCore;
namespace saleDemo.Models
{
    public class BaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<Role>();
            modelBuilder.Entity<Prodoct>();
            modelBuilder.Entity<Cart>();

        }

        public BaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
