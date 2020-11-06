using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodyCrawler.Models
{
    public class OrderModel
    {
        public string SDCode { get; set; }        

        public Entities.Item Item { get; set; }

        public int Amount { get; set; }
    }
}
