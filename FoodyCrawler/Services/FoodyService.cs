using FoodyCrawler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodyCrawler.Services
{
    public class FoodyService : IFoodyService
    {
        public async Task<IEnumerable<MenuModel>> GetMasterData(string foodyUrl)
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

            var result = JsonConvert.DeserializeObject<Rootobject>(content).reply.menu_infos;

            return result;
        }
    }
}
