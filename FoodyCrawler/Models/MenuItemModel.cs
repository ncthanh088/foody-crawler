using FoodyCrawler.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FoodyCrawler.Models
{
    public class MenuItemModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public Price Price { get; set; }

        [JsonProperty(PropertyName = "photos")]
        public IEnumerable<Photo> Photos { get; set; }
    }
}
