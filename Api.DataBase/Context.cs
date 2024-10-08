using Api.DataBase.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;

namespace Api.DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WebApiSokol;Username=postgres;Password=123");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(x => x.TypeProduct)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.TypeId);

            modelBuilder.Entity<Order>()
             .HasOne(x => x.Product)
             .WithMany(x => x.Orders)
             .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Order>()
           .HasOne(x => x.User)
           .WithMany(x => x.Orders)
           .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<TypeProduct>().HasData(new List<TypeProduct>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Товар"
                },
                  new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Услуга"
                },

            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
