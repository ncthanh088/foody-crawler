using System.Collections.Generic;

namespace FoodyCrawler.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string SDCode { get; set; }

        public IList<UserItem> UserOrders { get; set; }
    }
}
