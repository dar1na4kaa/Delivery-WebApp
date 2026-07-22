using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DeliveryOrderDbContext : DbContext
    {
        public DeliveryOrderDbContext(DbContextOptions<DeliveryOrderDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("orders");

                entity.Property(e => e.SenderCity);
                entity.Property(e => e.SenderAddress);
                entity.Property(e => e.RecipientCity);
                entity.Property(e => e.RecipientAddress);
                entity.Property(e => e.CargoWeight);
                entity.Property(e => e.PickupDate);
                entity.Property(e => e.OrderNumber);
            });
        }
    }
}
