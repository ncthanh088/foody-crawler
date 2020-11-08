using System.Collections.Generic;

namespace FoodyCrawler.Models
{
    public class OrderDetailModel
    {
        public int UserId { get; set; }

        public IEnumerable<OrderModel> OrderModels { get; set; }
    }
}
