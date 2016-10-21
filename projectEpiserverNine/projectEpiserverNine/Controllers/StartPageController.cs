using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EPiServer.Web.Mvc;
using StartPage = projectEpiserverNine.Models.Pages.StartPage;

namespace projectEpiserverNine.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currentPage)
        {
            return View();
        }
    }
}