using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebbShop1.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public  int NumberOfProducts { get; set; }

        public virtual Product Product { get; set; }
    }
}