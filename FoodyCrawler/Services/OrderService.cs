using FoodyCrawler.Entities;
using FoodyCrawler.Infrastructure;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public class OrderService : IOrderService
    {
        private readonly FoodyContext _foodyContext;

        public OrderService(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }

        public async Task<int> Create(Order order)
        {
            _foodyContext.Orders.Add(order);

            return await _foodyContext.SaveChangesAsync();
        }
    }
}
