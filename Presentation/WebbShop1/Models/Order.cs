﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebbShop1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        
        public virtual List<OrderItem> OrderItems  { get; set; }
    }
}