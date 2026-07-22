using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class OrderRepository(DeliveryOrderDbContext context) : IOrderRepository
    {
        public async Task AddAsync(Order order)
        {
            await context.Orders.AddAsync(order);
        }
        public async Task<IReadOnlyList<Order>> GetAllAsync()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<Order?> GetByOrderNumberAsync(Guid orderNumber)
        {
            return await context.Orders
                .FirstOrDefaultAsync(entity => entity.OrderNumber == orderNumber);
        }
        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
