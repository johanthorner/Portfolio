using System.Collections.Generic;
using System.Security.AccessControl;

namespace WebbShop1.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerAddress { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}