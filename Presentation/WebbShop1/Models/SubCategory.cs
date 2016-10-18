using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebbShop1.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}