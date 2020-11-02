using Newtonsoft.Json;

namespace FoodyCrawler.Models
{
    public class MenuItemModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public Price Price { get; set; }

        [JsonProperty(PropertyName = "photos")]
        public Photo[] Photos { get; set; }
    }
}
