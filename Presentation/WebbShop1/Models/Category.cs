using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebbShop1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}