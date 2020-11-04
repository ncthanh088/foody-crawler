using FoodyCrawler.Infrastructure;

namespace FoodyCrawler.Services
{
    public class OrderService : IOrderService
    {
        private readonly FoodyContext _foodyContext;

        public OrderService(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }
    }
}
