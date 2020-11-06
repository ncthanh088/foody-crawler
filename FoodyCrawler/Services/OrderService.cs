using FoodyCrawler.Infrastructure;
using FoodyCrawler.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public class OrderService : IOrderService
    {
        private readonly FoodyContext _context;

        public OrderService(FoodyContext foodyContext)
        {
            _context = foodyContext;
        }

        public async Task<IList<OrderModel>> GetOrder()
        {
            var orders = await _context.UserItems
                .Include(ui => ui.User)
                .Include(ui => ui.Item)
                    .ThenInclude(i=>i.Category)
                .Include(ui => ui.Item)
                    .ThenInclude(i => i.Photos)
                .Include(ui => ui.Item)
                    .ThenInclude(i => i.Price)
                .Select(o => new OrderModel
                {
                    SDCode = o.User.SDCode,
                    Item = o.Item,
                    Amount = o.Amount
                })
                .ToListAsync();

            return orders;
        }
    }
}
