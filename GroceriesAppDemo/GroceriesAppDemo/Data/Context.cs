using GroceriesAppDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceriesAppDemo.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<ProductsModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsModel>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
