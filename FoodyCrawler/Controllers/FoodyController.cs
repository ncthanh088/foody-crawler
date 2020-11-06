using FoodyCrawler.Entities;
using FoodyCrawler.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodyCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodyController : ControllerBase
    {
        private readonly IFoodyService _foodyService;
        private readonly IOrderService _orderService;

        public FoodyController(
            IFoodyService foodyService,
            IOrderService orderService)
        {
            _foodyService = foodyService;
            _orderService = orderService;
        }

        [HttpGet("GetFoodyMenu")]
        public async Task<ActionResult> GetFoodyMenu()
        {
            var foodyUrl = "https://gappapi.deliverynow.vn/api/dish/get_delivery_dishes?id_type=2&request_id=34383";

            var result = await _foodyService.GetMasterData(foodyUrl);

            return Ok(result);
        }

        [HttpGet("GetOrder")]        
        public async Task<ActionResult> GetOrder()
        {
            var result = await _orderService.GetOrder();

            return Ok(result);
        }
    }
}
