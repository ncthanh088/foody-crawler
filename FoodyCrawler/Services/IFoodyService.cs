using FoodyCrawler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public interface IFoodyService
    {
        Task<IEnumerable<MenuModel>> GetMasterData(string foodyUrl);
    }
}
