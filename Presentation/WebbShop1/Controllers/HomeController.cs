using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WebbShop1.Models;

namespace WebbShop1.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext db = new ProductContext();
        public ActionResult Index()
        {
            List<Category> CategoryList = db.Categories.ToList();
            return View(CategoryList);
        }

        public ActionResult About()
        {
            List<Product> activeProducts = db.Products.Where(p => p.ProductName.Contains("Volca")).ToList();

            return View(activeProducts);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpGet]
        public ActionResult ViewCart(bool? errorFromRedirect)
        {
            int currentOrder = 1;
            Order order = db.Orders.First(o => o.OrderId == currentOrder);

            bool error = Convert.ToBoolean(errorFromRedirect);
            if (error)
            {
                ViewBag.error = "Det blev fel.";
            }

            return View(order);
        }
         
        public ActionResult AdjustNumberOfItemsAdd(int id)
        {
            
            int currentOrder = 1;
            Order order = db.Orders.First(o => o.OrderId == currentOrder);

            foreach (var item in order.OrderItems)
            {
                if (item.Product.ProductID == id)
                {
                    item.NumberOfProducts++;
                }
            }

            db.SaveChanges();

            return RedirectToAction("ViewCart", new { });

        }
        public ActionResult AdjustNumberOfItemsRemove(int id)
        {
            try
            {
                int currentOrder = 1;
                Order order = db.Orders.First(o => o.OrderId == currentOrder);

                foreach (var item in order.OrderItems)
                {
                    if (item.Product.ProductID == id && item.NumberOfProducts == 1)
                    {
                        OrderItem itemToRemove = order.OrderItems.First(i => i.OrderItemId == id);
                        order.OrderItems.Remove(itemToRemove);
                    }
                    else
                    {
                        item.NumberOfProducts--;
                    }
                }

                db.SaveChanges();

                return RedirectToAction("ViewCart", new { });
            }
            catch (Exception)
            {
                //GÖr ett felmedelande
                return RedirectToAction("ViewCart");
            }
        }

        [HttpGet]
        public PartialViewResult checkOut()
        {
            int currentOrder = 1;
            Order order = db.Orders.First(o => o.OrderId == currentOrder);

            if (order.OrderItems.Count == 0)
            {
                ViewBag.message = "You have not selected any products jet.";
            }

            return PartialView(order);
        }

        [HttpGet]
        public PartialViewResult enterAddress()
        {
            int currentOrder = 1;
            Order order = db.Orders.First(o => o.OrderId == currentOrder);
            return PartialView(order);
        }

        [HttpGet]
        public ActionResult AddToCart(int id)
        {
            //call mvc via jquerry
            try
            {
                int currentOrder = 1;
                Order order = db.Orders.First(o => o.OrderId == currentOrder);

                Product selectedProduct = db.Products.First(p => p.ProductID == id);
                bool itemFound = false;
                foreach (var item in order.OrderItems)
                {

                    if (item.Product.ProductID == id)
                    {
                        item.NumberOfProducts++;
                        itemFound = true;
                    }
                }
                if (!itemFound)
                {

                    OrderItem newOrderItem = new OrderItem() { Product = selectedProduct, NumberOfProducts = 1 };
                    order.OrderItems.Add(newOrderItem);
                    db.SaveChanges();
                    TempData["NumberOfItemsInBasket"] = order.OrderItems.Count;
                }
                else
                {
                    db.SaveChanges();
                }

                return PartialView(order);
            }
            catch (Exception)
            {
                ViewBag.error = "Det sket sig";
            }

            return PartialView();

        }
        [HttpGet]
        public ActionResult SearchItem(string search)
        {
            List<Product> products = db.Products.Where(p => p.ProductName.Contains(search)).ToList();

            if (search == "")
            {
                ViewBag.SearchInput = "Var god skriv något i sökfälltet";
                List<Product> noProducts = db.Products.Where(p => p.ProductName.Contains("zzzz")).ToList();
                return PartialView(noProducts);

            }
            else
            {
                ViewBag.SearchInput = "Din sökning: '" + search + "': gav " + products.Count + " resultat";
                return PartialView(products);
            }

        }
        [HttpGet]
        public ActionResult RemoveFromCart(int id)
        {

            try
            {
                int currentOrder = 1;
                Order order = db.Orders.First(o => o.OrderId == currentOrder);
                OrderItem itemToRemove = order.OrderItems.First(i => i.OrderItemId == id);
                order.OrderItems.Remove(itemToRemove);

                db.SaveChanges();
                return RedirectToAction("ViewCart", "Home", new { error = false });
            }
            catch (Exception)
            {

                return RedirectToAction("ViewCart", "Home", new { error = true });
            }

        }

        [HttpGet]
        public ActionResult SubCategoryMenu(int id)
        {
            List<SubCategory> activeSubCategory = db.SubCategories.ToList().Where(a => a.Category.CategoryId == id).ToList();
            return PartialView(activeSubCategory);
        }
        [HttpPost]
        public ActionResult SubCategoryMenu()
        {
            List<SubCategory> activeSubCategory = db.SubCategories.ToList().Where(a => a.Category.CategoryId == 1).ToList();
            return PartialView(activeSubCategory);
        }

        [HttpGet]
        public PartialViewResult PrintProducts(int id)
        {
            ViewBag.id = id;
            ViewBag.selectedSubCategory = db.SubCategories.Where(s => s.SubCategoryId == id).ToList()[0].SubCategoryName;

            List<Product> activeProducts = db.Products.Where(p => p.SubCategory.SubCategoryId == id).ToList();
            return PartialView(activeProducts);
        }


        [HttpGet]
        public ActionResult ProductInfo(int id)
        {


            Product selectedProduct =
                   db.Products.First(p => p.ProductID == id);

            try
            {
                Manufacturer manufacturer = db.Manufacturers.First(m => m.ManufacturerId == selectedProduct.Manufacturer.ManufacturerId);
                ViewBag.Manufacturer = "Manufacturer: " + manufacturer.ManufacturerName + manufacturer.ManufacturerId;


                ViewBag.Manufacturer = "Manufacturer: " + manufacturer.ManufacturerName;

            }
            catch (Exception)
            {

                ViewBag.Manufacturer = "Kunde inte hitta manufacturer";
            }


            

            return PartialView(selectedProduct);
        }


    }
}