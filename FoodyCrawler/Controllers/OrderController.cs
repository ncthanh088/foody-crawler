using FoodyCrawler.Models;
using FoodyCrawler.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodyCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(
            IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetOrder")]
        public async Task<ActionResult> GetOrder()
        {
            var result = await _orderService.GetOrders();

            return Ok(result);
        }

        [HttpPost("CreateOrder")]
        public async Task<ActionResult> CreateOrder(OrderDetailModel orderDetailModel)
        {
            await _orderService.CreateOrder(orderDetailModel);

            return Ok();
        }
    }
}
