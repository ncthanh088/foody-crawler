using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodyCrawler.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Restaurant { get; set; }

        public IEnumerable<UserOrder> UserOrders { get; set; }

    }
}
