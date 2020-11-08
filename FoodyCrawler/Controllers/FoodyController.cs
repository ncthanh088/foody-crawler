using FoodyCrawler.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodyCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodyController : ControllerBase
    {
        private readonly IFoodyService _foodyService;

        public FoodyController(
            IFoodyService foodyService)
        {
            _foodyService = foodyService;
        }

        [HttpGet("GetFoodyMenu")]
        public async Task<ActionResult> GetFoodyMenu()
        {
            var shopUrl = "https://gappapi.deliverynow.vn/api/dish/get_delivery_dishes?request_id=69762&id_type=1";

            var result = await _foodyService.GetMasterData(shopUrl);

            return Ok(result);
        }
    }
}
