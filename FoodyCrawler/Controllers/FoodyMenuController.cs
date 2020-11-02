using FoodyCrawler.Models;
using FoodyCrawler.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodyCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodyMenuController : ControllerBase
    {
        private readonly IFoodyService _foodyService;

        public FoodyMenuController(IFoodyService foodyService)
        {
            _foodyService = foodyService;
        }

        [HttpGet]
        public async Task<MenuModel> GetFoodyMenu()
        {
         
            var menuInfo = await _foodyService.GetFoodyMenuInfos("https://gappapi.deliverynow.vn/api/dish/get_delivery_dishes?id_type=2&request_id=34383");
            
            var menu = new MenuModel();            

            return menu;
        }
    }
}
