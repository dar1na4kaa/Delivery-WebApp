using Application.DTO;

namespace Application.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(CreateOrderDto dto);
        Task<IReadOnlyList<OrderDto>> GetAllAsync();

        Task<OrderDto?> GetByOrderNumberAsync(Guid orderNumber);
    }
}
