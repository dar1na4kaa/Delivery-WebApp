using Application.DTO;
using Domain.Entities;

namespace Delivery.Application.Mappers;

public static class OrderMapper
{
    public static OrderDto ToDto(this Order order)
    {
        return new OrderDto
        {
            OrderNumber = order.OrderNumber,
            SenderCity = order.SenderCity,
            SenderAddress = order.SenderAddress,
            RecipientCity = order.RecipientCity,
            RecipientAddress = order.RecipientAddress,
            CargoWeight = order.CargoWeight,
            PickupDate = order.PickupDate
        };
    }
}