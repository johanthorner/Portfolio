using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebbShop1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductDatabase")
        {
            Database.SetInitializer<ProductContext>(new ProductContextIntializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }

    public class ProductContextIntializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {

            List<Category> Categories = new List<Category>()
            {
                new Category() {CategoryId = 0, CategoryName = "Synts"},
                new Category() {CategoryId = 1, CategoryName = "Drumachines"},
                new Category() {CategoryId = 2, CategoryName = "Speakers"},
                new Category() {CategoryId = 3, CategoryName = "Cables"}
            };
            foreach (var category in Categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();


            List<SubCategory> SubCategories = new List<SubCategory>()
            {
                new SubCategory() {SubCategoryId = 0, SubCategoryName = "Midi Synts", Category = Categories[0]},
                new SubCategory() {SubCategoryId = 1, SubCategoryName = "Analog Synts", Category = Categories[0]},
                
                new SubCategory() {SubCategoryId = 2, SubCategoryName = "Beat sequencers",Category = Categories[1]},
                new SubCategory() {SubCategoryId = 3, SubCategoryName = "Drum pads",Category = Categories[1]},

                new SubCategory() {SubCategoryId = 4, SubCategoryName = "Studio Speakers", Category = Categories[2]},
                new SubCategory() {SubCategoryId = 5, SubCategoryName = "Headphones", Category = Categories[2]},

                new SubCategory() {SubCategoryId = 6, SubCategoryName = "Midi cables",Category = Categories[3]},
                new SubCategory() {SubCategoryId = 7, SubCategoryName = "3.5 stereo cables",Category = Categories[3]},

            };
            foreach (var subCategory in SubCategories)
            {
                context.SubCategories.Add(subCategory);
            }
            context.SaveChanges();

            List<Manufacturer> Manufacturers = new List<Manufacturer>()
            {
                new Manufacturer() {ManufacturerId = 0, ManufacturerName = "Korg"},
                new Manufacturer() {ManufacturerId = 1, ManufacturerName = "Akai"},
                new Manufacturer() {ManufacturerId = 2, ManufacturerName = "Yamaha"},
                new Manufacturer() {ManufacturerId = 3, ManufacturerName = "Teenage Enginering"},
                new Manufacturer() {ManufacturerId = 4, ManufacturerName = "Artruria"}
            };
            foreach (var manufacturer in Manufacturers)
            {
                context.Manufacturers.Add(manufacturer);
            }
            context.SaveChanges();
            string descriptionTextLorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            List<Product> ProductList = new List<Product>()
            {
                //MidiSynts
                new Product() {ProductID = 0, ProductName = "Akai lpd8", ProductsInStock = 4, SubCategory = SubCategories[0], Manufacturer = Manufacturers[1], Price = 2390, OngoingCampain = false, Description = descriptionTextLorem},
                new Product() {ProductID = 1, ProductName = "Arturia microbrute", ProductsInStock = 7,SubCategory = SubCategories[0], Manufacturer = Manufacturers[4], Price = 5499, OngoingCampain = true, CampainPrice = 4499, Description = descriptionTextLorem},
                new Product() {ProductID = 2, ProductName = "Yamaha Dx1", ProductsInStock = 4, SubCategory = SubCategories[0], Manufacturer = Manufacturers[2],Price = 2999, OngoingCampain = false, Description = descriptionTextLorem},
                new Product() {ProductID = 3, ProductName = "Korg microbits", ProductsInStock = 7,SubCategory = SubCategories[0], Manufacturer = Manufacturers[0], Price = 1245, OngoingCampain = false, Description = descriptionTextLorem},
                //AnalogSynts

                new Product() {ProductID = 0, ProductName = "Volca Beats", ProductsInStock = 4, SubCategory = SubCategories[2],Manufacturer = Manufacturers[0] ,Price = 1499, OngoingCampain = false, Description = descriptionTextLorem},
                new Product() {ProductID = 1, ProductName = "Volca Sample", ProductsInStock = 7,SubCategory = SubCategories[2],Manufacturer = Manufacturers[0], Price = 1499, OngoingCampain = false, Description = descriptionTextLorem},
                new Product() {ProductID = 2, ProductName = "Volca Fm", ProductsInStock = 4, SubCategory = SubCategories[0],Manufacturer = Manufacturers[0],Price = 1499, OngoingCampain = false, Description = descriptionTextLorem},
                new Product() {ProductID = 3, ProductName = "Volca Bass", ProductsInStock = 7,SubCategory = SubCategories[0],Manufacturer = Manufacturers[0],Price = 1499, OngoingCampain = false, Description = descriptionTextLorem}

            };
            foreach (var product in ProductList)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            List<Customer> customers = new List<Customer>()
            {
                new Customer() {LastName = "Thörner", SureName = "Johan"}
            };
            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
            }
            context.SaveChanges();

            List<Order> Orders = new List<Order>()
            {
                new Order() {OrderId = 1, Customer = customers[0]},

            };
            foreach (var orders in Orders)
            {
                context.Orders.Add(orders);
            }
            context.SaveChanges();
            //TODO: lägg till mer produkter i context


        }
    }
}