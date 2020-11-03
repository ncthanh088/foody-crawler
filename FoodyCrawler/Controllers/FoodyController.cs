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

        [HttpGet]
        public async Task GetFoodyMenu()
        {
            var foodyUrl = "https://gappapi.deliverynow.vn/api/dish/get_delivery_dishes?id_type=2&request_id=34383";

            await _foodyService.GetMasterData(foodyUrl);
        }

        //[HttpGet]
        ////routin for this
        //public async Task OrderMenu()
        //{
        //    var userOrder = new UserOrder
        //    {
        //        User = new User
        //        {
        //            Username = "Username",
        //            Password = "P@ssw0rd"
        //        }
        //    };

        //    var userOrders = new List<UserOrder>();
        //    userOrders.Add(userOrder);

        //    var order = new Order
        //    {
        //        Restaurant = "Coo Ba",
        //        UserOrders = userOrders

        //    };

        //    await _orderService.Create(order);
        //}
    }
}
