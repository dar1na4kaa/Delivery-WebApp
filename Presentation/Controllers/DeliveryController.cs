using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class DeliveryController(IOrderService _orderService) : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }


            await _orderService.CreateAsync(dto);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<OrderDto>>> Index()
        {
            var orders = await _orderService.GetAllAsync();

            return View(orders);
        }
        [HttpGet("{orderNumber:guid}")]
        public async Task<IActionResult> Details(Guid orderNumber)
        {
            var order = await _orderService.GetByOrderNumberAsync(orderNumber);

            if (order is null)
                return NotFound();

            return View(order);
        }
    }
}
