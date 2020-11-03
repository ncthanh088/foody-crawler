using FoodyCrawler.Entities;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public interface IOrderService
    {
        Task<int> Create(Order order);
    }
}
