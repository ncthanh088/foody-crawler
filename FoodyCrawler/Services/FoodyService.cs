using FoodyCrawler.Entities;
using FoodyCrawler.Infrastructure;
using FoodyCrawler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public class FoodyService : IFoodyService
    {
        private readonly FoodyContext _foodyContext;

        public FoodyService(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }

        public async Task<int> GetMasterData(string foodyUrl)
        {
            var menuModels = await GetMenuModels(foodyUrl);

            foreach (var item in menuModels)
            {
                _foodyContext.Categories.Add(new Category
                {
                    Name = item.CategoryName,
                    Items = item.MenuItems.Select(x => new Entities.Item
                    {
                        Name = x.Name,
                        Photos = x.Photos,
                        Price = x.Price
                    }).ToList()
                });
            }

            var result = await _foodyContext.SaveChangesAsync();

            return result;
        }

        private async Task<IEnumerable<MenuModel>> GetMenuModels(string foodyUrl)
        {
            using var client = new HttpClient();

            client.BaseAddress = new Uri(foodyUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("x-foody-api-version", "1");
            client.DefaultRequestHeaders.Add("x-foody-app-type", "1004");
            client.DefaultRequestHeaders.Add("x-foody-client-language", "vi");
            client.DefaultRequestHeaders.Add("x-foody-client-type", "1");
            client.DefaultRequestHeaders.Add("x-foody-client-version", "3.0.0");
            client.DefaultRequestHeaders.Add("x-foody-client-id", "");

            var response = await client.GetAsync(foodyUrl);

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Rootobject>(content).
                reply.menu_infos as IEnumerable<MenuModel>;

            return result;
        }
    }
}
