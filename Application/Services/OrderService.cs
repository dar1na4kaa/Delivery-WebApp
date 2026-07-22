using Application.DTO;
using Application.Interfaces;
using Delivery.Application.Mappers;
using Domain.Entities;

namespace Application.Services
{
    public class OrderService(IOrderRepository repository) : IOrderService
    {
        public async Task CreateAsync(CreateOrderDto dto)
        {
            var order = Order.CreateOrder(
                dto.SenderCity,
                dto.SenderAddress,
                dto.RecipientCity,
                dto.RecipientAddress,
                dto.CargoWeight,
                dto.PickupDate);

            await repository.AddAsync(order);

            await repository.SaveAsync();
        }

        public async Task<IReadOnlyList<OrderDto>> GetAllAsync()
        {
            var orders = await repository.GetAllAsync();

            return orders
                .Select(entity => entity.ToDto())
                .ToList();
        }

        public async Task<OrderDto?> GetByOrderNumberAsync(Guid orderNumber)
        {
            var order = await repository.GetByOrderNumberAsync(orderNumber);

            return order?.ToDto();
        }
    }
}
