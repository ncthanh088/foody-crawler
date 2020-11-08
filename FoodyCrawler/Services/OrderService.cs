using FoodyCrawler.Entities;
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

        public async Task<IEnumerable<UserOrderModel>> GetOrders()
        {

            var userOrders = await _context.UserItems
                .Select(userOrder => new UserOrderModel
                {
                    Username = userOrder.User.Username,
                    SDcode = userOrder.User.SDCode,
                    Item = userOrder.Item,
                    Amount = userOrder.Amount,
                    Price = userOrder.Item.Price.value,
                    Total = (userOrder.Amount * userOrder.Item.Price.value)
                })
                .ToListAsync();

            return userOrders;
        }

        public async Task CreateOrder(OrderDetailModel orderDetailModel)
        {
            foreach (var item in orderDetailModel.OrderModels)
            {
                var userItem = new UserItem
                {
                    UserId = orderDetailModel.UserId,
                    ItemId = item.ItemId,
                    Amount = item.Amount
                };

                var userItemEntity = _context.UserItems
                    .Where(x => x.UserId == userItem.UserId
                        && x.ItemId == userItem.ItemId)
                    .FirstOrDefault();

                if (userItemEntity == null)
                {
                    _context.UserItems.Add(userItem);
                }
                else
                {
                    userItemEntity.Amount = userItem.Amount;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
