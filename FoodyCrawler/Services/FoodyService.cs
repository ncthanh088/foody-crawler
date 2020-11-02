using FoodyCrawler.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public class FoodyService : IFoodyService
    {
        public async Task<IEnumerable<MenuModel>> GetFoodyMenuInfos(string menuUrl)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(menuUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("x-foody-api-version", "1");
                client.DefaultRequestHeaders.Add("x-foody-app-type", "1004");
                client.DefaultRequestHeaders.Add("x-foody-client-language", "vi");
                client.DefaultRequestHeaders.Add("x-foody-client-type", "1");
                client.DefaultRequestHeaders.Add("x-foody-client-version", "3.0.0");
                client.DefaultRequestHeaders.Add("x-foody-client-id", "");

                var response = await client.GetAsync(menuUrl);
                var jsonContent = await response.Content.ReadAsStringAsync();

                var menuInfos = JsonConvert.DeserializeObject<Rootobject>(jsonContent).reply.menu_infos;


                return null;
            }
        }

        public Task<IEnumerable<Dish>> GetFoodyDishesByMenuInfo(int dishTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
