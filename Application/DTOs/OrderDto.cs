namespace Application.DTO
{
    public class OrderDto
    {
        public Guid OrderNumber { get; set; }

        public string SenderCity { get; set; } = string.Empty;

        public string SenderAddress { get; set; } = string.Empty;

        public string RecipientCity { get; set; } = string.Empty;

        public string RecipientAddress { get; set; } = string.Empty;

        public decimal CargoWeight { get; set; }

        public DateOnly PickupDate { get; set; }
    }
}
