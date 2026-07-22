using System;

namespace Domain.Entities
{
    public class Order
    {
        public int Id { get; }

        public Guid OrderNumber { get; set; }
        public string SenderCity { get; }
        public string SenderAddress { get; }
        public string RecipientCity { get; }
        public string RecipientAddress { get; }
        public decimal CargoWeight { get; }
        public DateOnly PickupDate { get; }
        private Order(string senderCity, string senderAddress, string recipientCity, string recipientAddress, decimal cargoWeight, DateOnly pickupDate, Guid orderNumber)
        {
            SenderCity = senderCity;
            SenderAddress = senderAddress;
            RecipientCity = recipientCity;
            RecipientAddress = recipientAddress;
            CargoWeight = cargoWeight;
            PickupDate = pickupDate;
            OrderNumber = orderNumber;
        }

        public static Order CreateOrder(string senderCity, string senderAddress, string recipientCity, string recipientAddress, decimal cargoWeight, DateOnly pickupDate)
        {
            if (string.IsNullOrWhiteSpace(senderCity)) throw new ArgumentNullException("Sender city can not be empty or null");
            if (string.IsNullOrWhiteSpace(senderAddress)) throw new ArgumentNullException("Sender address can not be empty or null");
            if (string.IsNullOrWhiteSpace(recipientCity)) throw new ArgumentNullException("Recipient city can not be empty or null");
            if (string.IsNullOrWhiteSpace(recipientAddress)) throw new ArgumentNullException("Recipient address can not be empty or null");
            if (cargoWeight <= 0) throw new ArgumentNullException("Cargo weight can not be less than 0");
            if (pickupDate < DateOnly.FromDateTime(DateTime.Now)) throw new ArgumentException("Pickup date can not be later than creation date");
            if (pickupDate == DateOnly.MinValue) throw new ArgumentException("Pickup date can not be empty");
            var orderNumber = System.Guid.NewGuid();
            return new Order(senderCity, senderAddress, recipientCity, recipientAddress, cargoWeight, pickupDate, orderNumber);
        }
    }
}