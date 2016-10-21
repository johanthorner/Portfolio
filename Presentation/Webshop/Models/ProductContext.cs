using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webshop.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductDatabase")
        {
            Database.SetInitializer<ProductContext>(new ProductContextInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }

    public class ProductContextInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            List<Product> Products = new List<Product>()
            {
                new Product() {ProductId = 1, ProductName = "Korg Volca Beats", ProductsInStock = 12},
                new Product() {ProductId = 2, ProductName = "Korg Volca Sample", ProductsInStock = 7}
            };
            foreach (var product in Products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }

        
        
    }
}