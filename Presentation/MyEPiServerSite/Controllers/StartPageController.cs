using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using MyEPiServerSite.Models.Pages;

namespace MyEPiServerSite.Controllers
{
    public class StartPage1Controller : PageController<StartPage1>
    {
        public ActionResult Index(StartPage1 currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}