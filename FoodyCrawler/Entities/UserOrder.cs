using System.Collections.Generic;

namespace FoodyCrawler.Entities
{
    public class UserOrder
    {
        public int Id { get; set; }
        
        public string Username { get; set; }

        public IEnumerable<Item> Items { get; set; }

        public User User { get; set; }
    }
}
