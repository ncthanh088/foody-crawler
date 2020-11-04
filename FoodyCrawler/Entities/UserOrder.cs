using System.Collections.Generic;

namespace FoodyCrawler.Entities
{
    public class UserOrder
    {
        public int Id { get; set; }
        
        public int Amount { get; set; }
        
        public User User { get; set; }

        public Item Item { get; set; }
    }
}
