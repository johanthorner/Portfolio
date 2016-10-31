using System.Linq;
using System.Web.Mvc;
using WebbShop1.Models;

namespace WebbShop1.Controllers
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        private ProductContext db = new ProductContext();
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            int currentOrder = 1;
            Order order = db.Orders.First(o => o.OrderId == currentOrder);
            filterContext.Controller.ViewBag.OnActionExecuted = order.GetNumberOfItems();
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            int currentOrder = 1;
            Order order = db.Orders.First(o => o.OrderId == currentOrder);
            filterContext.Controller.ViewBag.OnActionExecuted = order.GetNumberOfItems();

        }

    }
}