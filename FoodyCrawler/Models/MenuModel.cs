using Newtonsoft.Json;
using System.Collections.Generic;

namespace FoodyCrawler.Models
{
    public class MenuModel
    {
        [JsonProperty(PropertyName = "dish_type_id")]
        public int CategoryId { get; set; }

        [JsonProperty(PropertyName = "dish_type_name")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "dishes")]
        public List<MenuItemModel> MenuItems { get; set; }
    }
}
