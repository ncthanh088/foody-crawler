using FoodyCrawler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public interface IOrderService
    {
        Task<IList<OrderModel>> GetOrder();
    }
}
