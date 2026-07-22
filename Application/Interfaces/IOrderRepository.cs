using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);

        Task<Order?> GetByOrderNumberAsync(Guid orderNumber);

        Task<IReadOnlyList<Order>> GetAllAsync();
        Task SaveAsync();

    }
}