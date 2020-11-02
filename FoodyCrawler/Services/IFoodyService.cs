using FoodyCrawler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public interface IFoodyService
    {
        Task<IEnumerable<MenuModel>> GetFoodyMenuInfos(string menuUrl);
        Task<IEnumerable<Dish>> GetFoodyDishesByMenuInfo(int dishTypeId);
    }
}
