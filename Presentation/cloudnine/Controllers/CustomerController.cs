using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using cloudnine.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace cloudnine.Controllers
{
    public class CustomerController : BlockController<Customer>
    {
        public override ActionResult Index(Customer currentBlock)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(currentBlock);
        }
    }
}