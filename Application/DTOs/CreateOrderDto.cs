using System.ComponentModel.DataAnnotations;

public class CreateOrderDto
{
    [Required(ErrorMessage = "Укажите город отправителя")]
    public string SenderCity { get; set; }


    [Required(ErrorMessage = "Укажите адрес отправителя")]
    public string SenderAddress { get; set; }


    [Required(ErrorMessage = "Укажите город получателя")]
    public string RecipientCity { get; set; }


    [Required(ErrorMessage = "Укажите адрес получателя")]
    public string RecipientAddress { get; set; }

    [Required(ErrorMessage = "Укажите вес заказа")]
    [Range(0.1, 10000, ErrorMessage = "Вес должен быть от 0.1 кг")]
    public decimal CargoWeight { get; set; }


    [Required(ErrorMessage = "Укажите дату")]
    public DateOnly PickupDate { get; set; }
}