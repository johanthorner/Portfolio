using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebbShop1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public double Price { get; set; }
        public double CampainPrice { get; set; }
        public bool OngoingCampain { get; set; }
        public string ProductName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int ProductsInStock { get; set; }
        public string Description { get; set; }

        public SubCategory SubCategory { get; set; }
        public virtual Order Order { get; set; }

    }

  
}