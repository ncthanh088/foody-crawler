using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public interface IFoodyService
    {
        Task<int> GetMasterData(string foodyUrl);
    }
}
