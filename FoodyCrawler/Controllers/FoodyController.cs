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

        public FoodyController(IFoodyService foodyService)
        {
            _foodyService = foodyService;
        }

        [HttpGet]
        public async Task GetFoodyMenu()
        {
            var foodyUrl = "https://gappapi.deliverynow.vn/api/dish/get_delivery_dishes?id_type=2&request_id=34383";
            
            await _foodyService.GetMasterData(foodyUrl);            
        }
    }
}
